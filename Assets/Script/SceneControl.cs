using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SceneControl : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            if (other.gameObject.GetComponent<PhotonView>().IsMine)
            {
                PhotonNetwork.Destroy(other.gameObject);
            }
        }
    }
}
