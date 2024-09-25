using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class MenuManager : MonoBehaviour
{
    public Image soundSprite;
    public Image musicSprite;

    private void Awake()
    {
        SetSoundSprite();
        SetMusicSprite();
    }
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void SoundButton()
    {
        transform.localScale = new Vector3(1, 1, 1);

        AssetManager.Use.PlaySound(7);

        if (PlayerPrefs.GetInt(VariablesName.Sound, 1) == 1)
        {
            PlayerPrefs.SetInt(VariablesName.Sound, 0);
        }
        else
        {
            PlayerPrefs.SetInt(VariablesName.Sound, 1);
        }

        PlayerPrefs.Save();
        AssetManager.Use.SetSoundVolume();
        SetSoundSprite();
    }
    public void SetSoundSprite()
    {
        if (PlayerPrefs.GetInt(VariablesName.Sound, 1) == 1)
        {
            soundSprite.color = Color.white;
        }
        else
        {
            soundSprite.color = Color.grey;
        }
    }
    public void SetMusicSprite()
    {
        if (PlayerPrefs.GetInt(VariablesName.Sound, 1) == 1)
        {
            soundSprite.color = Color.white;
        }
        else
        {
            soundSprite.color = Color.grey;
        }
    }
    public void MusicButton()
    {
        transform.localScale = new Vector3(1, 1, 1);

        AssetManager.Use.PlaySound(7);

        if (PlayerPrefs.GetInt(VariablesName.Music, 1) == 1)
        {
            PlayerPrefs.SetInt(VariablesName.Music, 0);
        }
        else
        {
            PlayerPrefs.SetInt(VariablesName.Music, 1);
        }

        PlayerPrefs.Save();
        AssetManager.Use.SetMusicVolume();
        SetMusicSprite();
    }
}
