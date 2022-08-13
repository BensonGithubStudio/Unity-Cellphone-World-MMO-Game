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
    public GameObject LoadingBar;
    public Text LoadingText;
    public Button StartButton;

    public AudioSource BackgroundMusicAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.SetQualityLevel(5);

        StartButton.interactable = false;
        ConnectingUI.gameObject.SetActive(true);
        WaitingInGameUI.gameObject.SetActive(false);
        PhotonNetwork.AutomaticallySyncScene = true;
        BackgroundMusicAudioSource.Stop();


        if (!PhotonNetwork.IsConnected)
        {
            ConnectingUI.SetBool("Is Connect", false);
            PhotonNetwork.ConnectUsingSettings();
        }
        else
        {
            LoadingText.text = "20%";
        }
    }

    public override void OnConnectedToMaster()
    {
        BackgroundMusicAudioSource.Play();

        StartButton.interactable = true;
        LoadingText.text = "80%";
        LoadingBar.transform.localPosition = new Vector3(-80, 0, 0);
        Invoke("LoadingMiddle", 0.1f);
    }

    void LoadingMiddle()
    {
        LoadingText.text = "100%";
        LoadingBar.transform.localPosition = new Vector3(0, 0, 0);
        Invoke("LoadingSuccess", 0.5f);
    }

    void LoadingSuccess()
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
