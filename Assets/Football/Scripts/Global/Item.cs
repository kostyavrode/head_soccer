using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    HEAD,
    CLOTH,
    SHOES,
    BALL,
    FIELD
}

public class Item : MonoBehaviour
{
    public TMP_Text costText;
    public int cost;
    public int itemNumber;

    public Sprite sprite;
    public Image itemImg;

    public bool isCanInteract=true;

    public ItemType itemType;


    public GameObject costObject;
    private void Awake()
    {
        
    }
    private void OnEnable()
    {
        costText.text = cost.ToString();
        itemImg.sprite = sprite;
    }
    public void Buy()
    {
        if (isCanInteract)
        {
            if (PlayerPrefs.GetInt("Money") >= cost)
            {
                PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - cost);
                PlayerPrefs.SetInt("Item" + itemNumber, 0);
                SetBought();
                Debug.Log("Bought");
            }
            else
            {
                Shop.instance.ShowNotEnoughBar();
            }
        }
        else
        {


            switch (itemType)
            {
                case ItemType.HEAD:
                    ShopPlayerView.instance.SetHead(sprite);
                    break;
                case ItemType.CLOTH:
                    ShopPlayerView.instance.SetBody(sprite);
                    break;
                case ItemType.SHOES:
                    ShopPlayerView.instance.SetShoes(sprite);
                    break;
                case ItemType.BALL:
                    ShopPlayerView.instance.SetBall(sprite);
                    break;
                case ItemType.FIELD:
                    ShopPlayerView.instance.SetField(sprite);
                    break;
                default:
                    return;
            }
        }
    }
    public void SetBought()
    {
        //GetComponent<Button>().interactable = false;
        costObject.SetActive(false);
        isCanInteract = false;
    }
}
