using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class StartNetworkManager : MonoBehaviourPunCallbacks
{
    public Animator ConnectingUI;
    public Animator WaitingInGameUI;

    // Start is called before the first frame update
    void Start()
    {
        ConnectingUI.gameObject.SetActive(true);
        WaitingInGameUI.gameObject.SetActive(false);
        PhotonNetwork.AutomaticallySyncScene = true;

        if (!PhotonNetwork.IsConnected)
        {
            ConnectingUI.SetBool("Is Connect", false);
            PhotonNetwork.ConnectUsingSettings();
        }
        else
        {
            DestroyConnectUI();
        }
    }

    public override void OnConnectedToMaster()
    {
        
        ConnectingUI.SetBool("Is Connect", true);
        Invoke("DestroyConnectUI", 1.2f);
    }

    void DestroyConnectUI()
    {
        ConnectingUI.gameObject.SetActive(false);
    }

    public void OnClickStartGame()
    {
        WaitingInGameUI.gameObject.SetActive(true);
        PhotonNetwork.JoinRoom("World");
    }

    public override void OnJoinRoomFailed(short returnCode, string message)
    {
        PhotonNetwork.CreateRoom("World");
    }

    public override void OnJoinedRoom()
    {
        WaitingInGameUI.SetBool("Is Ready", true);
        if (PhotonNetwork.IsMasterClient)
        {
            Invoke("GoInGame", 0.5f);
        }
    }

    void GoInGame()
    {
        SceneManager.LoadScene("World Scene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
