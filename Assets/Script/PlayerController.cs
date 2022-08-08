using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviourPunCallbacks
{
    public GameObject Player;
    public PhotonView pv;
    public GameObject Cam;

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
}
