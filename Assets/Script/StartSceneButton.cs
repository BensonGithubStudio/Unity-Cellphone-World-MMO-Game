using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneButton : MonoBehaviour
{
    public GameObject ChooseCharacterImage;
    public GameObject[] CharacterKind;

    // Start is called before the first frame update
    void Start()
    {
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter()
    {
        ChooseCharacterImage.SetActive(true);
    }
    public void OnClickCloseCharacter()
    {
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter1()
    {
        PlayerPrefs.SetInt("Character", 0);
        for(int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter2()
    {
        PlayerPrefs.SetInt("Character", 1);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter3()
    {
        PlayerPrefs.SetInt("Character", 2);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter4()
    {
        PlayerPrefs.SetInt("Character", 3);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter5()
    {
        PlayerPrefs.SetInt("Character", 4);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter6()
    {
        PlayerPrefs.SetInt("Character", 5);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        ChooseCharacterImage.SetActive(false);
    }
}
