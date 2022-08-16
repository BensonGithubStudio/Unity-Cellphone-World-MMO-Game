using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class GiveGifts : MonoBehaviour
{
    public GameObject Player;
    public PhotonView pv;

    public Button GiveGiftButton;

    void Start()
    {
        GiveGiftButton = GameObject.FindGameObjectWithTag("Give Gift").GetComponent<Button>();
        GiveGiftButton.onClick.AddListener(delegate () { OnClickGiveGift(); });
    }

    public void OnClickGiveGift()
    {
        if(PlayerPrefs.GetInt("Level") > 1)
        {
            PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") - 1);
            CallRPCGiveGiftToFriend(Player.transform.position);
        }
    }

    void CallRPCGiveGiftToFriend(Vector3 p)
    {
        pv.RPC("RPCGiveGiftToFriend", RpcTarget.MasterClient, p);
    }

    [PunRPC]
    void RPCGiveGiftToFriend(Vector3 p)
    {
        int number = Random.Range(1, 6);
        string GiftName = "Gift " + number;

        PhotonNetwork.InstantiateRoomObject(GiftName, new Vector3(p.x + Random.Range(1f, -1f), p.y + 2, p.z + 2), Quaternion.Euler(45, 0, 45), 0, null);
    }
}
