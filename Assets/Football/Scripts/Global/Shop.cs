using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shop : MonoBehaviour
{
    public static Shop instance;
    public TMP_Text moneyText;
    public Item[] buyButtons;
    public GameObject notEnoughObject;
    private void OnEnable()
    {
        instance = this;
        moneyText.text = PlayerPrefs.GetInt("Money").ToString();
        CheckBuyings();
    }
    private void OnDisable()
    {
        instance = null;
    }
    public void UpdateMoney()
    {
        moneyText.text = PlayerPrefs.GetInt("Money").ToString();
    }
    public void ShowNotEnoughBar()
    {
        StartCoroutine(ShowNotEnoughCoroutine());
    }
    private void CheckBuyings()
    {
        for (int i = 0; i < buyButtons.Length; i++)
        {
            if (PlayerPrefs.HasKey("Item"+i))
            {
                buyButtons[i].SetBought();
            }
            else
            {
                buyButtons[i].isCanInteract = true;
            }
        }
    }
    private IEnumerator ShowNotEnoughCoroutine()
    {
        notEnoughObject.SetActive(true);
        yield return new WaitForSeconds(1);
        notEnoughObject.SetActive(false);   
    }
}
