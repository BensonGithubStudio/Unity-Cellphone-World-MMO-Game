using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CharacterAbility : MonoBehaviourPunCallbacks
{
    public bool Connect;

    public float Attack;
    public float Blood;
    public float Speed;
    public float range;

    public GameObject AttackUI;
    public GameObject BloodUI;
    public GameObject SpeedUI;
    public GameObject rangeUI;

    public float AttackUIPosition;
    public float BloodUIPosition;
    public float SpeedUIPosition;
    public float rangeUIPosition;

    // Start is called before the first frame update
    void Start()
    {
        Connect = false;

        AttackUI.SetActive(true);
        BloodUI.SetActive(true);
        SpeedUI.SetActive(true);
        rangeUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Connect)
        {
            AttackUI.transform.localPosition = new Vector3(AttackUIPosition - 300, 0f, 0f);
            BloodUI.transform.localPosition = new Vector3(BloodUIPosition - 300, 0f, 0f);
            SpeedUI.transform.localPosition = new Vector3(SpeedUIPosition - 300, 0f, 0f);
            rangeUI.transform.localPosition = new Vector3(rangeUIPosition - 300, 0f, 0f);

            if (PlayerPrefs.GetInt("Character") == 0)
            {
                //正常
                Attack = 150;
                Blood = 150;
                Speed = 150;
                range = 150;
            }
            if (PlayerPrefs.GetInt("Character") == 1)
            {
                //散彈
                Attack = 280;
                Blood = 280;
                Speed = 120;
                range = 50;
            }
            if (PlayerPrefs.GetInt("Character") == 2)
            {
                //長射程
                Attack = 250;
                Blood = 100;
                Speed = 250;
                range = 280;
            }
            if (PlayerPrefs.GetInt("Character") == 3)
            {
                //範圍
                Attack = 280;
                Blood = 300;
                Speed = 140;
                range = 30;
            }
            if (PlayerPrefs.GetInt("Character") == 4)
            {
                //連續直線
                Attack = 240;
                Blood = 120;
                Speed = 200;
                range = 230;
            }
            if (PlayerPrefs.GetInt("Character") == 5)
            {
                //散彈直線
                Attack = 260;
                Blood = 100;
                Speed = 180;
                range = 190;
            }
            if (PlayerPrefs.GetInt("Character") == 6)
            {
                //拋物線
                Attack = 230;
                Blood = 130;
                Speed = 230;
                range = 200;
            }
            if (PlayerPrefs.GetInt("Character") == 7)
            {
                //散彈隨機
                Attack = 170;
                Blood = 220;
                Speed = 220;
                range = 270;
            }
        }
    }

    void FixedUpdate()
    {
        if (AttackUIPosition > Attack)
        {
            AttackUIPosition -= 1;
        }
        else
        {
            AttackUIPosition += 1;
        }

        if (BloodUIPosition > Blood)
        {
            BloodUIPosition -= 1;
        }
        else
        {
            BloodUIPosition += 1;
        }

        if (SpeedUIPosition > Speed)
        {
            SpeedUIPosition -= 1;
        }
        else
        {
            SpeedUIPosition += 1;
        }

        if (rangeUIPosition > range)
        {
            rangeUIPosition -= 1;
        }
        else
        {
            rangeUIPosition += 1;
        }
    }

    public override void OnConnectedToMaster()
    {
        Connect = true;
    }
}
