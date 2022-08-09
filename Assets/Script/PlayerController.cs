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
    public GameObject BloodBar;
    public GameObject MiddleBloodBar;
    public GameObject ShootAim;    

    [Header("玩家狀態")]
    public bool CanMove;
    public bool CanShoot;
    public float NowHp;
    public float FollowHp;
    public bool CanTreat;

    [Header("參數設定")]
    public float MoveSpeed;
    public string BulletKind;
    public float MaxHp;
    public float HpFollowSpeed;

    // Start is called before the first frame update
    void Start()
    {
        CanShoot = false;
        NowHp = MaxHp;
        FollowHp = MaxHp;
        CanTreat = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (pv.IsMine)
        {
            CameraCheck();
            GameUICheck();
            JoystickCheck();
            BloodBarCheck();
            ShootAimCheck();
            PlayerRotate();
            ShootRotate();
            ShootControl();
            BloodBarControl();
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

    void BloodBarCheck()
    {
        GameObject[] bloodBars = GameObject.FindGameObjectsWithTag("Blood Bar");
        GameObject[] middleBars = GameObject.FindGameObjectsWithTag("Blood Bar Middle");
        foreach (GameObject bloodBar in bloodBars)
        {
            if (bloodBar.GetComponent<PhotonView>().IsMine)
            {
                BloodBar = bloodBar;
            }
            else
            {
                Destroy(bloodBar);

            }
        }
        foreach(GameObject middleBar in middleBars)
        {
            if (middleBar.GetComponent<PhotonView>().IsMine)
            {
                MiddleBloodBar = middleBar;
            }
            else
            {
                Destroy(middleBar);
            }
        }
    }

    void ShootAimCheck()
    {
        GameObject[] shoots = GameObject.FindGameObjectsWithTag("Shoot Aim");
        foreach (GameObject shoot in shoots)
        {
            if (shoot.GetComponent<PhotonView>().IsMine)
            {
                ShootAim = shoot;
            }
            else
            {
                Destroy(shoot);
            }
        }
        ShootAim.transform.position = Player.transform.position;
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

    void ShootRotate()
    {
        if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x > 0.5f || ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x < -0.5f || ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y > 0.5f || ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y < -0.5f)
        {
            ShootAim.SetActive(true);
            CanShoot = true;
            if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y > 0)
            {
                ShootAim.transform.localEulerAngles = new Vector3(0, 90 * ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x, 0);
            }
            if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y < 0)
            {
                ShootAim.transform.localEulerAngles = new Vector3(0, 180 - (90 * ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x), 0);
            }
        }
        else
        {
            ShootAim.SetActive(false);
        }
    }

    void ShootControl()
    {
        if (CanShoot)
        {
            if(ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x == 0 && ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y == 0)
            {
                Player.transform.eulerAngles = new Vector3(ShootAim.transform.localEulerAngles.x, ShootAim.transform.localEulerAngles.y, ShootAim.transform.localEulerAngles.z);
                PhotonNetwork.Instantiate(BulletKind, Player.transform.position, Quaternion.Euler(ShootAim.transform.localEulerAngles.x, ShootAim.transform.localEulerAngles.y, ShootAim.transform.localEulerAngles.z));
                CanShoot = false;
            }
        }
    }

    void BloodBarControl()
    {
        BloodBar.transform.localPosition = new Vector3(-800 + (NowHp / MaxHp) * 800, 0, 0);
        MiddleBloodBar.transform.localPosition = new Vector3(-800 + (FollowHp / MaxHp) * 800, 0, 0);

        if (FollowHp > NowHp)
        {
            FollowHp -= HpFollowSpeed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (pv.IsMine)
        {
            if (other.gameObject.tag == "Bullet")
            {
                if (!other.gameObject.GetComponent<PhotonView>().IsMine)
                {
                    NowHp -= other.gameObject.GetComponent<BulletControl>().BulletStrong;
                }
            }
        }
    }
}
