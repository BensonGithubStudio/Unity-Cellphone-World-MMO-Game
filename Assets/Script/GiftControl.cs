using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GiftControl : MonoBehaviour
{
    public PhotonView pv;
    public GameObject Gift;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player Body")
        {
            if (!collision.gameObject.GetComponent<PhotonView>().IsMine)
            {
                PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
                PhotonNetwork.Destroy(Gift);
            }
        }
    }*/
}
