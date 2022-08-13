using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;

public class SettingControl : MonoBehaviour
{
    public GameObject SettingAllUI;
    public GameObject QualitySettingUI;
    public GameObject SoundAndMusicSettingUI;
    public Slider MusicSlider;
    public GameObject GameDataUI;
    public GameObject SpecialUI;
    public Toggle CanRotateToggle;
    public GameObject PlayerInformationUI;
    public GameObject PreferUI;

    void Start()
    {
        SettingAllUI.SetActive(false);

        QualitySettingUI.SetActive(false);
        SoundAndMusicSettingUI.SetActive(false);
        MusicSlider.value = 1;
        GameDataUI.SetActive(false);
        SpecialUI.SetActive(false);
        PlayerInformationUI.SetActive(false);
        PreferUI.SetActive(false);

        CanRotateToggle.isOn = false;
    }

    void Update()
    {
        this.gameObject.GetComponent<WorldNetworkManager>().BackgroundAudioSource.volume = MusicSlider.value;
    }

    public void OnClickLeaveGame()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void OnClickOpenSetting()
    {
        SettingAllUI.SetActive(true);
    }

    public void OnClickCloseSetting()
    {
        SettingAllUI.SetActive(false);
    }

    public void OnClickQualitySetting()
    {
        if (QualitySettingUI.activeSelf)
        {
            QualitySettingUI.SetActive(false);
        }
        else
        {
            SoundAndMusicSettingUI.SetActive(false);
            GameDataUI.SetActive(false);
            PlayerInformationUI.SetActive(false);
            PreferUI.SetActive(false);
            SpecialUI.SetActive(false);
            QualitySettingUI.SetActive(true);
        }
    }

    public void OnClickVeryLowQuality()
    {
        QualitySettings.SetQualityLevel(0);
    }
    public void OnClickLowQuality()
    {
        QualitySettings.SetQualityLevel(1);
    }
    public void OnClickMediumQuality()
    {
        QualitySettings.SetQualityLevel(2);
    }
    public void OnClickHighQuality()
    {
        QualitySettings.SetQualityLevel(3);
    }
    public void OnClickVeryHighQuality()
    {
        QualitySettings.SetQualityLevel(4);
    }
    public void OnClickUltraQuality()
    {
        QualitySettings.SetQualityLevel(5);
    }

    public void OnClickSoundAndMusicSetting()
    {
        if (SoundAndMusicSettingUI.activeSelf)
        {
            SoundAndMusicSettingUI.SetActive(false);
        }
        else
        {
            QualitySettingUI.SetActive(false);
            GameDataUI.SetActive(false);
            PlayerInformationUI.SetActive(false);
            PreferUI.SetActive(false);
            SpecialUI.SetActive(false);
            SoundAndMusicSettingUI.SetActive(true);
        }
    }

    public void OnClickSpecialSetting()
    {
        if (SpecialUI.activeSelf)
        {
            SpecialUI.SetActive(false);
        }
        else
        {
            SoundAndMusicSettingUI.SetActive(false);
            GameDataUI.SetActive(false);
            PlayerInformationUI.SetActive(false);
            PreferUI.SetActive(false);
            QualitySettingUI.SetActive(false);
            SpecialUI.SetActive(true);
        }
    }

    public void OnClickCharacterCanRotate()
    {
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player Body");
        GameObject MyPlayer = null;

        foreach (GameObject player in players)
        {
            if (player.GetComponent<PhotonView>().IsMine)
            {
                MyPlayer = player;
            }
        }

        if (CanRotateToggle.isOn) {
            MyPlayer.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
        else
        {
            MyPlayer.gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        }
    }

    public void OnClickGameDataSetting()
    {
        if (GameDataUI.activeSelf)
        {
            GameDataUI.SetActive(false);
        }
        else
        {
            QualitySettingUI.SetActive(false);
            SoundAndMusicSettingUI.SetActive(false);
            PlayerInformationUI.SetActive(false);
            PreferUI.SetActive(false);
            SpecialUI.SetActive(false);
            GameDataUI.SetActive(true);
        }
    }

    public void OnClickDeletePlayerLevelData()
    {
        PlayerPrefs.DeleteKey("Name");
        PlayerPrefs.DeleteKey("Level");
    }

    public void OnClickPlayerInformation()
    {
        if (PlayerInformationUI.activeSelf)
        {
            PlayerInformationUI.SetActive(false);
        }
        else
        {
            QualitySettingUI.SetActive(false);
            SoundAndMusicSettingUI.SetActive(false);
            GameDataUI.SetActive(false);
            PreferUI.SetActive(false);
            SpecialUI.SetActive(false);
            PlayerInformationUI.SetActive(true);
        }
    }

    public void OnClickPrefer()
    {
        if (PreferUI.activeSelf)
        {
            PreferUI.SetActive(false);
        }
        else
        {
            QualitySettingUI.SetActive(false);
            SoundAndMusicSettingUI.SetActive(false);
            GameDataUI.SetActive(false);
            PlayerInformationUI.SetActive(false);
            SpecialUI.SetActive(false);
            PreferUI.SetActive(true);
        }
    }
}
