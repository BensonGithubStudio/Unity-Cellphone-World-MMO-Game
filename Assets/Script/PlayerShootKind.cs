using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerShootKind : MonoBehaviour
{
    public int Character4ShootTimes;
    public int Character7ShootTimes;

    public void PlayerAimShoot()
    {
        if (PlayerPrefs.GetInt("Character") == 0) {
            PhotonNetwork.Instantiate("Bullet 1", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
        }

        if (PlayerPrefs.GetInt("Character") == 1)
        {
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 10, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 20, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 30, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y - 10, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y - 20, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y - 30, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));

        }

        if (PlayerPrefs.GetInt("Character") == 2)
        {
            PhotonNetwork.Instantiate("Bullet 3", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
        }

        if (PlayerPrefs.GetInt("Character") == 3)
        {
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 45, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 90, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 135, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 180, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y - 45, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y -90, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y - 135, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
        }

        if(PlayerPrefs.GetInt("Character") == 4)
        {
            Character4ShootTimes = 0;
            Character4AimShoot();
        }

        if (PlayerPrefs.GetInt("Character") == 5)
        {
            PhotonNetwork.Instantiate("Bullet 6", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 6", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + 20, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 6", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y - 20, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
        }

        if (PlayerPrefs.GetInt("Character") == 6)
        {
            Character7ShootTimes = 0;
            Character7AutoShoot();
        }

        if (PlayerPrefs.GetInt("Character") == 7)
        {
            PhotonNetwork.Instantiate("Bullet 8", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
        }
    }

    public void PlayerAutoShoot()
    {
        if (PlayerPrefs.GetInt("Character") == 0)
        {
            PhotonNetwork.Instantiate("Bullet 1", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
        }

        if (PlayerPrefs.GetInt("Character") == 1)
        {
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 10, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 20, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 30, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y - 10, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y - 20, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 2", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y - 30, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));

        }

        if (PlayerPrefs.GetInt("Character") == 2)
        {
            PhotonNetwork.Instantiate("Bullet 3", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
        }

        if (PlayerPrefs.GetInt("Character") == 3)
        {
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 45, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 90, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 135, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 180, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y - 45, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y - 90, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 4", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y - 135, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
        }

        if(PlayerPrefs.GetInt("Character") == 4)
        {
            Character4ShootTimes = 0;
            Character4AutoShoot();
        }

        if (PlayerPrefs.GetInt("Character") == 5)
        {
            PhotonNetwork.Instantiate("Bullet 6", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 6", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + 20, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            PhotonNetwork.Instantiate("Bullet 6", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y - 20, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
        }

        if (PlayerPrefs.GetInt("Character") == 6)
        {
            Character7ShootTimes = 0;
            Character7AutoShoot();
        }

        if (PlayerPrefs.GetInt("Character") == 7)
        {
            PhotonNetwork.Instantiate("Bullet 8", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
        }
    }

    void Character4AimShoot()
    {
        if (Character4ShootTimes < 5)
        {
            PhotonNetwork.Instantiate("Bullet 5", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            Character4ShootTimes += 1;
            Invoke("Character4AimShoot", 0.1f);
        }
    }

    void Character4AutoShoot()
    {
        if (Character4ShootTimes < 5)
        {
            PhotonNetwork.Instantiate("Bullet 5", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            Character4ShootTimes += 1;
            Invoke("Character4AutoShoot", 0.1f);
        }
    }

    void Character7AimShoot()
    {
        if (Character7ShootTimes < 5)
        {
            float a = Random.Range(-20f, 20f);
            PhotonNetwork.Instantiate("Bullet 7", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.y + a, this.gameObject.GetComponent<PlayerController>().ShootAim.transform.localEulerAngles.z));
            Character7ShootTimes += 1;
            Invoke("Character7AimShoot", 0.1f);
        }
    }

    void Character7AutoShoot()
    {
        if (Character7ShootTimes < 5)
        {
            float a = Random.Range(-20f, 20);
            PhotonNetwork.Instantiate("Bullet 7", new Vector3(this.gameObject.GetComponent<PlayerController>().Player.transform.position.x, this.gameObject.GetComponent<PlayerController>().Player.transform.position.y + 0.2f, this.gameObject.GetComponent<PlayerController>().Player.transform.position.z), Quaternion.Euler(this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.x, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.y + a, this.gameObject.GetComponent<PlayerController>().Player.transform.localEulerAngles.z));
            Character7ShootTimes += 1;
            Invoke("Character7AutoShoot", 0.1f);
        }
    }
}
