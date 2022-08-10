using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSceneButton : MonoBehaviour
{
    public float ClickTime;
    public float ClickMaxTime;

    public GameObject ChooseCharacterImage;
    public GameObject[] CharacterKind;

    // Start is called before the first frame update
    void Start()
    {
        ChooseCharacterImage.SetActive(false);
        ClickTime = 0;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Camera.main.ScreenToViewportPoint(Input.mousePosition).x>0.3f&& Camera.main.ScreenToViewportPoint(Input.mousePosition).x < 0.7f)
            {
                ClickTime += Time.deltaTime;
            }
        }
        else
        {
            ClickTime = 0;
        }
    }

    public void OnClickChooseCharacter()
    {
        if (ClickTime <= ClickMaxTime)
        {
            ChooseCharacterImage.SetActive(true);
        }
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
