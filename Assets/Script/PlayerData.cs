using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public InputField PlayerName;
    public Text PlayerLevel;
    public GameObject[] CharacterKind;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            PlayerName.text = PlayerPrefs.GetString("Name");
        }
        if (PlayerPrefs.HasKey("Level"))
        {
            PlayerLevel.text = "" + PlayerPrefs.GetInt("Level");
        }

        if (PlayerPrefs.HasKey("Character"))
        {
            CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        }
        else
        {
            PlayerPrefs.SetInt("Character", 7);
            CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        }
    }

    public void SavePlayerName()
    {
        PlayerPrefs.SetString("Name", PlayerName.text);
    }
}
