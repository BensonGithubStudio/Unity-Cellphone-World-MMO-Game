using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class WorldNetworkManager : MonoBehaviourPunCallbacks
{
    public int StartPositionCount;
    public GameObject[] StartPosition;
    public GameObject WifiImage;

    public AudioSource BackgroundAudioSource;
    public AudioClip[] BackgroundSound;

    // Start is called before the first frame update
    void Start()
    {
        WifiImage.SetActive(false);

        if (PhotonNetwork.IsConnected == false)
        {
            SceneManager.LoadScene("Start Scene");
        }
        else
        {
            int sound = Random.Range(0, BackgroundSound.Length);
            BackgroundAudioSource.clip = BackgroundSound[sound];
            BackgroundAudioSource.Play();

            int count = Random.Range(0, StartPositionCount);
            PhotonNetwork.Instantiate("Main Camera", StartPosition[count].transform.position, Quaternion.Euler(90, 0, 0));
            PhotonNetwork.Instantiate("Game UI", StartPosition[count].transform.position, Quaternion.identity);
            if (PlayerPrefs.GetInt("Character") == 0)
            {
                PhotonNetwork.Instantiate("Player 1", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 1", StartPosition[count].transform.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("Character") == 1)
            {
                PhotonNetwork.Instantiate("Player 2", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 2", StartPosition[count].transform.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("Character") == 2)
            {
                PhotonNetwork.Instantiate("Player 3", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 3", StartPosition[count].transform.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("Character") == 3)
            {
                PhotonNetwork.Instantiate("Player 4", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 4", StartPosition[count].transform.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("Character") == 4)
            {
                PhotonNetwork.Instantiate("Player 5", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 5", StartPosition[count].transform.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("Character") == 5)
            {
                PhotonNetwork.Instantiate("Player 6", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 6", StartPosition[count].transform.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("Character") == 6)
            {
                PhotonNetwork.Instantiate("Player 7", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 7", StartPosition[count].transform.position, Quaternion.identity);
            }
            else if (PlayerPrefs.GetInt("Character") == 7)
            {
                PhotonNetwork.Instantiate("Player 8", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim 8", StartPosition[count].transform.position, Quaternion.identity);
            }
        }
    }

    void Update()
    {
        if (PhotonNetwork.GetPing() > 200)
        {
            WifiImage.SetActive(true);
        }
        else
        {
            WifiImage.SetActive(false);
        }
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
