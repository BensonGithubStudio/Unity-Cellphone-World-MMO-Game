using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartSceneButton : MonoBehaviour
{
    public float ClickTime;
    public float ClickMaxTime;

    public AudioSource ButtonAudioSource;
    public AudioClip ClickSound;
    public AudioClip ChooseSound;

    public GameObject ChooseCharacterImage;
    public GameObject[] CharacterKind;
    public GameObject[] IntroduceText;

    // Start is called before the first frame update
    void Start()
    {
        ChooseCharacterImage.SetActive(false);
        ClickTime = 0;
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
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
            ButtonAudioSource.PlayOneShot(ClickSound);
            ChooseCharacterImage.SetActive(true);
        }
    }
    public void OnClickCloseCharacter()
    {
        ButtonAudioSource.PlayOneShot(ClickSound);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter1()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 0);
        for(int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, 200, 0);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter2()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 1);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, 200, 0);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter3()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 2);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, 200, 0);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter4()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 3);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, 200, 0);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter5()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 4);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, 0, 0);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.GetChild(0).transform.localEulerAngles = new Vector3(0, 200, 0);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter6()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 5);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, 0, 0);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.GetChild(0).transform.localEulerAngles = new Vector3(0, 200, 0);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter7()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 6);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, -180, 0);
        ChooseCharacterImage.SetActive(false);
    }

    public void OnClickChooseCharacter8()
    {
        ButtonAudioSource.PlayOneShot(ChooseSound);
        PlayerPrefs.SetInt("Character", 7);
        for (int i = 0; i < CharacterKind.Length; i++)
        {
            CharacterKind[i].SetActive(false);
            IntroduceText[i].SetActive(false);
        }
        CharacterKind[PlayerPrefs.GetInt("Character")].SetActive(true);
        IntroduceText[PlayerPrefs.GetInt("Character")].SetActive(true);
        CharacterKind[PlayerPrefs.GetInt("Character")].transform.localEulerAngles = new Vector3(0, 180, 0);
        ChooseCharacterImage.SetActive(false);
    }
}
