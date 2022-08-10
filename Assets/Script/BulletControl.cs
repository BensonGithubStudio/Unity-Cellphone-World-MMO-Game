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

    void OnCollisionEnter(Collision collision)
    {
        print("111");
        if (pv.IsMine)
        {
            if (collision.gameObject.tag == "Untagged")
            {
                PhotonNetwork.Destroy(this.gameObject);
            }
        }
    }
}
