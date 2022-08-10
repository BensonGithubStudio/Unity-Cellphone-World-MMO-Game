using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BulletControl : MonoBehaviour
{
    public PhotonView pv;
    public float LifeTime;
    public float MoveSpeed;
    public float BulletStrong;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pv.IsMine)
        {
            LifeTime -= Time.deltaTime;
            if (LifeTime <= 0)
            {
                PhotonNetwork.Destroy(this.gameObject);
            }

            transform.Translate(0, 0, MoveSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (pv.IsMine)
        {
            if (other.gameObject.tag == "Player Body")
            {
                if (!other.gameObject.GetComponent<PhotonView>().IsMine)
                {
                    print("123");
                }
            }
        }
    }
}
