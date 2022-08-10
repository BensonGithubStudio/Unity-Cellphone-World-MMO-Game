using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    public InputField PlayerName;
    public Text PlayerLevel;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Name"))
        {
            PlayerName.text = PlayerPrefs.GetString("Name");
        }
        if (PlayerPrefs.HasKey("Level"))
        {
            PlayerLevel.text = "" + (PlayerPrefs.GetInt("Level") / 2);
        }
    }

    public void SavePlayerName()
    {
        PlayerPrefs.SetString("Name", PlayerName.text);
    }
}
