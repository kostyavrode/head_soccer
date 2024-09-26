using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPlayerView : MonoBehaviour
{
    public static ShopPlayerView instance;

    public Image head;
    public Image body;
    public Image shoes;
    public Image shoes2;
    public Image ball;
    public Image field;

    private void OnEnable()
    {
        instance = this;
    }
    private void OnDisable()
    {
        instance = null;
    }
    public void SetHead(Sprite h)
    {
        head.sprite = h;
    }
    public void SetBody(Sprite b)
    {
        body.sprite = b;
    }
    public void SetShoes(Sprite s)
    {
        shoes.sprite = s;
        shoes2.sprite = s;
    }
    public void SetBall(Sprite b)
    {
        ball.sprite = b;
    }
    public void SetField(Sprite f)
    {
        field.sprite = f;
    }

}
