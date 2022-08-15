using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using UnityEngine.UI;

public class SettingControl : MonoBehaviour
{
    public GameObject MyPlayer;

    public AudioSource ButtonAudioSource;
    public AudioClip ClickButtonSound;

    public GameObject SettingAllUI;
    public GameObject QualitySettingUI;
    public GameObject SoundAndMusicSettingUI;
    public Slider MusicSlider;
    public Slider SoundSlider;
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
        SoundSlider.value = 1;
        GameDataUI.SetActive(false);
        SpecialUI.SetActive(false);
        PlayerInformationUI.SetActive(false);
        PreferUI.SetActive(false);

        CanRotateToggle.isOn = false;
    }

    void Update()
    {
        this.gameObject.GetComponent<WorldNetworkManager>().BackgroundAudioSource.volume = MusicSlider.value;
        ButtonAudioSource.volume = SoundSlider.value;

        GameObject[] players = GameObject.FindGameObjectsWithTag("Player Body");
        foreach(GameObject player in players)
        {
            if (player.GetComponent<PhotonView>().IsMine)
            {
                MyPlayer = player;
            }
        }
        if (MyPlayer != null)
        {
            MyPlayer.GetComponent<AudioSource>().volume = SoundSlider.value;
        }
    }

    public void OnClickLeaveGame()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        PhotonNetwork.LeaveRoom();
    }

    public void OnClickOpenSetting()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        SettingAllUI.SetActive(true);
    }

    public void OnClickCloseSetting()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        SettingAllUI.SetActive(false);
    }

    public void OnClickQualitySetting()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
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
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        QualitySettings.SetQualityLevel(0);
    }
    public void OnClickLowQuality()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        QualitySettings.SetQualityLevel(1);
    }
    public void OnClickMediumQuality()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        QualitySettings.SetQualityLevel(2);
    }
    public void OnClickHighQuality()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        QualitySettings.SetQualityLevel(3);
    }
    public void OnClickVeryHighQuality()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        QualitySettings.SetQualityLevel(4);
    }
    public void OnClickUltraQuality()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        QualitySettings.SetQualityLevel(5);
    }

    public void OnClickSoundAndMusicSetting()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
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
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
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
        ButtonAudioSource.PlayOneShot(ClickButtonSound);

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
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
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
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        PlayerPrefs.DeleteKey("Name");
        PlayerPrefs.DeleteKey("Level");
        PhotonNetwork.LeaveRoom();
    }

    public void OnClickDeleteAllData()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
        PlayerPrefs.DeleteAll();
        PhotonNetwork.LeaveRoom();
    }

    public void OnClickDeletePreferData()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void OnClickDeleteQualityData()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void OnClickPlayerInformation()
    {
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
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
        ButtonAudioSource.PlayOneShot(ClickButtonSound);
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
