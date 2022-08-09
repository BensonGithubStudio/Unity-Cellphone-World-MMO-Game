using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SettingControl : MonoBehaviour
{
    //畫質設定36~71
    //遊戲音效設定

    public GameObject SettingAllUI;
    public GameObject QualitySettingUI;
    public GameObject SoundAndMusicSettingUI;

    void Start()
    {
        SettingAllUI.SetActive(false);

        QualitySettingUI.SetActive(false);
        SoundAndMusicSettingUI.SetActive(false);
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
            SoundAndMusicSettingUI.SetActive(true);
        }
    }
}
