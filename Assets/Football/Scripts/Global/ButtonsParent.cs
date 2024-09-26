using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsParent : MonoBehaviour
{
    public static ButtonsParent instance;
    public ButtonScript[] buttons;
    private void OnEnable()
    {
        instance = this;
    }
    private void OnDisable()
    {
        instance = null;
    }
    public void DisableItherButtons(ButtonScript button)
    {
        foreach (ButtonScript buttonScript in buttons)
        {
            if (buttonScript.GetHashCode() != button.GetHashCode())
            {
                if (buttonScript.isScaled)
                {
                    buttonScript.Scale();
                }
                buttonScript.openedObject.SetActive(false);
            }
        }
    }
}
