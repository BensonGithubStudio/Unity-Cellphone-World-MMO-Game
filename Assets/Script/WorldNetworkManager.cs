using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;

public class WorldNetworkManager : MonoBehaviourPunCallbacks
{
    public int StartPositionCount;
    public GameObject[] StartPosition;

    // Start is called before the first frame update
    void Start()
    {
        if (PhotonNetwork.IsConnected == false)
        {
            SceneManager.LoadScene("Start Scene");
        }
        else
        {
            int count = Random.Range(0, StartPositionCount);
            PhotonNetwork.Instantiate("Main Camera", StartPosition[count].transform.position, Quaternion.Euler(90, 0, 0));
            PhotonNetwork.Instantiate("Game UI", StartPosition[count].transform.position, Quaternion.identity);
            if (PlayerPrefs.GetInt("Character") == 0)
            {
                PhotonNetwork.Instantiate("Player 1", StartPosition[count].transform.position, Quaternion.identity);
                PhotonNetwork.Instantiate("Shoot Aim", StartPosition[count].transform.position, Quaternion.identity);
            }
        }
    }

    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("Start Scene");
    }
}
