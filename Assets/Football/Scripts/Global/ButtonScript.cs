using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public bool isScaled;
    public GameObject openedObject;
    public void Scale()
    {
        if (isScaled)
        {
            transform.localScale = Vector3.one;
            isScaled = false;
            openedObject.SetActive(false);
        }
        else
        {
            openedObject.SetActive(true);
            isScaled = true;
            transform.localScale= Vector3.one*1.3f;
            ButtonsParent.instance.DisableItherButtons(this);
        }
    }
    public void SetButtonBought()
    {

    }
}
