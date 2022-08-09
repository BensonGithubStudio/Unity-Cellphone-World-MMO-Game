using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class SettingControl : MonoBehaviour
{
    public GameObject SettingAllUI;
    public GameObject QualitySettingUI;

    void Start()
    {
        SettingAllUI.SetActive(false);

        QualitySettingUI.SetActive(false);
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
}
