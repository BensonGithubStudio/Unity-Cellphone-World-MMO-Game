using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPunCallbacks
{
    public GameObject Player;
    public PhotonView pv;
    public Rigidbody PlayerRigidBody;

    [Header("玩家附屬物件管理")]
    public GameObject Cam;
    public GameObject GameUI;
    public GameObject MoveJoystick;
    public GameObject ShootJoystick;

    [Header("玩家狀態")]
    public bool CanMove;

    [Header("參數設定")]
    public float MoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pv.IsMine)
        {
            CameraCheck();
            GameUICheck();
            JoystickCheck();
            PlayerRotate();
        }
    }

    void FixedUpdate()
    {
        if (pv.IsMine)
        {
            PlayerMove();
        }
    }

    void CameraCheck()
    {
        GameObject[] Cams = GameObject.FindGameObjectsWithTag("MainCamera");
        foreach (GameObject cam in Cams)
        {
            if (cam.GetComponent<PhotonView>().IsMine)
            {
                Cam = cam;
            }
            else
            {
                Destroy(cam);
            }
        }

        Cam.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 10, Player.transform.position.z);
    }

    void GameUICheck()
    {
        GameObject[] GameUIs = GameObject.FindGameObjectsWithTag("Game UI");
        foreach (GameObject gameUI in GameUIs)
        {
            if (gameUI.GetComponent<PhotonView>().IsMine)
            {
                GameUI = gameUI;
            }
            else
            {
                Destroy(gameUI);
            }
        }
    }

    void JoystickCheck()
    {
        GameObject[] moves = GameObject.FindGameObjectsWithTag("Move Joystick");
        GameObject[] shoots = GameObject.FindGameObjectsWithTag("Shoot Joystick");
        foreach (GameObject move in moves)
        {
            if (move.GetComponent<PhotonView>().IsMine)
            {
                MoveJoystick = move;
            }
            else
            {
                Destroy(move);
            }
        }
        foreach (GameObject shoot in shoots)
        {
            if (shoot.GetComponent<PhotonView>().IsMine)
            {
                ShootJoystick = shoot;
            }
            else
            {
                Destroy(shoot);
            }
        }
    }

    void PlayerRotate()
    {
        if(MoveJoystick.GetComponent<JoyStickControl>().InputDirection.x != 0|| MoveJoystick.GetComponent<JoyStickControl>().InputDirection.y != 0)
        {
            CanMove = true;
        }
        else
        {
            CanMove = false;
        }

        if (MoveJoystick.GetComponent<JoyStickControl>().InputDirection.y > 0)
        {
            Player.transform.localEulerAngles = new Vector3(0, 90 * MoveJoystick.GetComponent<JoyStickControl>().InputDirection.x, 0);
        }
        if (MoveJoystick.GetComponent<JoyStickControl>().InputDirection.y < 0)
        {
            Player.transform.localEulerAngles = new Vector3(0, 180 - (90 * MoveJoystick.GetComponent<JoyStickControl>().InputDirection.x), 0);
        }
    }

    void PlayerMove()
    {
        if (CanMove)
        {
            
            if (PlayerRigidBody.velocity.magnitude < 5)
            {
                PlayerRigidBody.AddRelativeForce(0, 0, MoveSpeed);
            }
        }
    }
}
