using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

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
    public GameObject LeaveButton;
    public GameObject EnergyBar;

    [Header("動畫管理")]
    public Animator PlayerAnimator;

    [Header("玩家狀態")]
    public bool CanMove;
    public bool ClickLeaveRoom;
    public bool CanShoot;
    public bool AutoShoot;
    public bool DontAutoShoot;
    public float NowHp;
    public float FollowHp;
    public bool CanTreat;
    public bool IsAlive;
    public float NowEnergy;

    [Header("參數設定")]
    public float MoveSpeed;
    public float MaxSpeed;
    public string BulletKind;
    public float MaxHp;
    public float HpFollowSpeed;
    public float CamMoveSpeed;
    public float treatTime;
    public float EnergySpeed;
    public float ShootWaitTime;

    [Header("子彈類型")]
    public bool SingleKind;//單一子彈
    public bool RandomKind;//某範圍內隨機
    public bool RangeKind;//周圍
    public bool ContinueStraightKind;//連續直線
    public bool ScatterKind;//散彈
    public bool ScatterStraightKind;//分散直線

    // Start is called before the first frame update
    void Start()
    {
        CanShoot = false;
        ClickLeaveRoom = false;
        AutoShoot = false;
        DontAutoShoot = true;
        NowHp = MaxHp;
        FollowHp = MaxHp;
        CanTreat = true;
        IsAlive = true;
        treatTime = 3;
        PlayerAnimator.SetBool("IsDie", false);
        PlayerAnimator.enabled = false;
        ShootWaitTime = 0;
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
            EnergyBarCheck();
            LeaveButtonCheck();

            if (IsAlive)
            {
                PlayerRotate();
                ShootRotate();
                ShootControl();
                BloodTreat();

                ShootWaitTime += Time.deltaTime;
            }


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

        if (IsAlive)
        {
            Cam.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y + 10, Player.transform.position.z);
        }
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

    void EnergyBarCheck()
    {
        GameObject[] energys = GameObject.FindGameObjectsWithTag("Energy Bar");
        foreach (GameObject energy in energys)
        {
            if (energy.GetComponent<PhotonView>().IsMine)
            {
                EnergyBar = energy;
            }
            else
            {
                Destroy(energy);
            }
        }

        if (NowEnergy < 0)
        {
            NowEnergy += EnergySpeed;
            EnergyBar.transform.localPosition = new Vector3(NowEnergy, 0, 0);
        }
    }

    void LeaveButtonCheck()
    {
        GameObject[] buttons = GameObject.FindGameObjectsWithTag("Leave Button");
        foreach (GameObject button in buttons)
        {
            if (button.GetComponent<PhotonView>().IsMine)
            {
                LeaveButton = button;
                LeaveButton.GetComponent<Button>().onClick.AddListener(delegate () { OnClickLeaveGame(); });
            }
            else
            {
                Destroy(button);
            }
        }
        if (IsAlive)
        {
            LeaveButton.SetActive(false);
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
            
            if (PlayerRigidBody.velocity.magnitude < MaxSpeed)
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
            AutoShoot = false;
            DontAutoShoot = true;
            if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y > 0)
            {
                ShootAim.transform.localEulerAngles = new Vector3(0, 90 * ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x, 0);
            }
            if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y < 0)
            {
                ShootAim.transform.localEulerAngles = new Vector3(0, 180 - (90 * ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x), 0);
            }
        }
        else if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x != 0 && ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y != 0)
        {
            ShootAim.SetActive(false);
            CanShoot = false;
            if (!DontAutoShoot)
            {
                AutoShoot = true;
            }
        }
        else
        {
            ShootAim.SetActive(false);
            DontAutoShoot = false;
        }
    }

    void ShootControl()
    {
        if (CanShoot)
        {
            if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x == 0 && ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y == 0)
            {
                if (ShootWaitTime >= 0.5f)
                {
                    if (NowEnergy >= -534)
                    {
                        Player.transform.eulerAngles = new Vector3(ShootAim.transform.localEulerAngles.x, ShootAim.transform.localEulerAngles.y, ShootAim.transform.localEulerAngles.z);
                        //PhotonNetwork.Instantiate(BulletKind, new Vector3(Player.transform.position.x, Player.transform.position.y + 0.2f, Player.transform.position.z), Quaternion.Euler(ShootAim.transform.localEulerAngles.x, ShootAim.transform.localEulerAngles.y, ShootAim.transform.localEulerAngles.z));
                        Player.gameObject.GetComponent<PlayerShootKind>().PlayerAimShoot();

                        NowEnergy -= 267;
                    }

                    ShootWaitTime = 0;
                }
                CanShoot = false;
            }
        }

        if (AutoShoot)
        {
            if (ShootJoystick.GetComponent<JoyStickControl>().InputDirection.x == 0 && ShootJoystick.GetComponent<JoyStickControl>().InputDirection.y == 0)
            {
                if (ShootWaitTime >= 0.5f)
                {
                    if (NowEnergy >= -534)
                    {
                        GameObject[] ScenePlayers = GameObject.FindGameObjectsWithTag("Player Body");
                        int PlayersCount = ScenePlayers.Length;
                        float[] distance = new float[PlayersCount];
                        int i = 0;
                        GameObject TargetObject = null;
                        float TempDistance = 0;

                        foreach (GameObject player in ScenePlayers)
                        {
                            if (!player.GetComponent<PhotonView>().IsMine)
                            {
                                distance[i] = Vector3.Distance(Player.transform.position, player.transform.position);
                                i++;
                            }
                            else
                            {
                                distance[i] = 1000000;
                                i++;
                            }
                        }

                        i = 0;

                        foreach (float dis in distance)
                        {
                            if (TargetObject == null)
                            {
                                TargetObject = ScenePlayers[i];
                                TempDistance = dis;
                            }

                            if (TempDistance > dis)
                            {
                                TempDistance = dis;
                                TargetObject = ScenePlayers[i];
                            }
                            i++;
                        }

                        transform.LookAt(TargetObject.transform);
                        //PhotonNetwork.Instantiate(BulletKind, new Vector3(Player.transform.position.x, Player.transform.position.y + 0.2f, Player.transform.position.z), Quaternion.Euler(Player.transform.localEulerAngles.x, Player.transform.localEulerAngles.y, Player.transform.localEulerAngles.z));
                        Player.gameObject.GetComponent<PlayerShootKind>().PlayerAutoShoot();

                        NowEnergy -= 267;
                    }

                    ShootWaitTime = 0;
                }
                AutoShoot = false;
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

        if (NowHp <= 0)
        {
            if (IsAlive)
            {
                CallRPCAddGift(Player.transform.position);

                LeaveButton.SetActive(true);
                PlayerAnimator.enabled = true;
                PlayerAnimator.SetBool("IsDie", true);
                IsAlive = false;
            }
            if (Cam.transform.position.y <= 11.5f)
            {
                Cam.transform.Translate(0, 0, -CamMoveSpeed * Time.deltaTime);
            }
        }else if (NowHp <= MaxHp / 4)
        {
            BloodBar.GetComponent<Animator>().SetBool("Full", false);
            BloodBar.GetComponent<Animator>().SetBool("Middle", false);
            BloodBar.GetComponent<Animator>().SetBool("Danger", true);
        }else if (NowHp <= MaxHp / 2)
        {
            BloodBar.GetComponent<Animator>().SetBool("Full", false);
            BloodBar.GetComponent<Animator>().SetBool("Middle", true);
            BloodBar.GetComponent<Animator>().SetBool("Danger", false);
        }
        else
        {
            BloodBar.GetComponent<Animator>().SetBool("Full", true);
            BloodBar.GetComponent<Animator>().SetBool("Middle", false);
            BloodBar.GetComponent<Animator>().SetBool("Danger", false);
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
                    treatTime = 3;
                    CancelInvoke("Treat");
                    CanTreat = true;
                    NowHp -= other.gameObject.GetComponent<BulletControl>().BulletStrong;
                }
            }

            if(other.gameObject.tag == "Gift")
            {
                PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
                CallRPCDestroyGift(other.gameObject.GetComponent<PhotonView>().ViewID);
            }
        }
    }

    void BloodTreat()
    {
        treatTime -= Time.deltaTime;

        if (treatTime <= 0)
        {
            if (NowHp < MaxHp)
            {
                if (CanTreat)
                {
                    InvokeRepeating("Treat", 0, 1);
                    CanTreat = false;
                }
            }
            else
            {
                CancelInvoke("Treat");
                CanTreat = true;
            }
        }
    }

    void Treat()
    {
        if (IsAlive)
        {
            if (MaxHp - NowHp >= MaxHp / 6)
            {
                NowHp += MaxHp / 6;
                FollowHp = NowHp;
            }
            else
            {
                NowHp += (MaxHp - NowHp);
                FollowHp = NowHp;
            }
        }
        else
        {
            CancelInvoke("Treat");
        }
    }

    public void OnClickLeaveGame()
    {
        if (!ClickLeaveRoom)
        {
            ClickLeaveRoom = true;
            PhotonNetwork.LeaveRoom();
        }
    }

    void CallRPCAddGift(Vector3 p)
    {
        pv.RPC("RPCAddGift", RpcTarget.MasterClient, p);
    }

    void CallRPCDestroyGift(int id)
    {
        pv.RPC("RPCDestroyGift", RpcTarget.MasterClient, id);
    }

    [PunRPC]
    void RPCAddGift(Vector3 p)
    {
        PhotonNetwork.InstantiateRoomObject("Gift 1", new Vector3(p.x + Random.Range(-2f, 2f), p.y + 2, p.z + Random.Range(-2f, 2f)), Quaternion.Euler(45, 0, 45), 0, null);
        PhotonNetwork.InstantiateRoomObject("Gift 2", new Vector3(p.x + Random.Range(-2f, 2f), p.y + 2, p.z + Random.Range(-2f, 2f)), Quaternion.Euler(45, 0, 45), 0, null);
        PhotonNetwork.InstantiateRoomObject("Gift 3", new Vector3(p.x + Random.Range(-2f, 2f), p.y + 2, p.z + Random.Range(-2f, 2f)), Quaternion.Euler(45, 0, 45), 0, null);
        PhotonNetwork.InstantiateRoomObject("Gift 4", new Vector3(p.x + Random.Range(-2f, 2f), p.y + 2, p.z + Random.Range(-2f, 2f)), Quaternion.Euler(45, 0, 45), 0, null);
        PhotonNetwork.InstantiateRoomObject("Gift 5", new Vector3(p.x + Random.Range(-2f, 2f), p.y + 2, p.z + Random.Range(-2f, 2f)), Quaternion.Euler(45, 0, 45), 0, null);
    }

    [PunRPC]
    void RPCDestroyGift(int id)
    {
        PhotonNetwork.Destroy(PhotonView.Find(id).gameObject);
    }
}
