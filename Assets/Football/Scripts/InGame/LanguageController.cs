using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LanguageController : MonoBehaviour
{
    public string[] portugal;
    public string[] english;
    public TMP_Text[] textBars;
    private void OnEnable()
    {
        CheckLanguage();
    }
    public void LanguageButton()
    {
        if (PlayerPrefs.GetInt("lang")==0)
        {
            SwitchToPortugal();
        }
        else
        {
            SwitchToEnglish();
        }
    }
    private void CheckLanguage()
    {
        if (PlayerPrefs.GetInt("lang")==1)
        {
            SwitchToPortugal();
        }
        else
        {
            SwitchToEnglish();
        }
    }
    private void SwitchToPortugal()
    {
        PlayerPrefs.SetInt("lang", 1);
        PlayerPrefs.Save();
        for(int i = 0; i < textBars.Length; i++)
        {
            textBars[i].text=portugal[i];
        }
    }
    private void SwitchToEnglish()
    {
        PlayerPrefs.SetInt("lang", 0);
        PlayerPrefs.Save();
        for (int i = 0; i < textBars.Length; i++)
        {
            textBars[i].text = english[i];
        }
    }
}
