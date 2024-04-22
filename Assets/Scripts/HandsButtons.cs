using System.Collections;
using System.Collections.Generic;

using UnityEditor.PackageManager.UI;

using UnityEngine;

public class HandsButtons : MonoBehaviour
{
    [SerializeField] GameObject Window;
   
    public void rotateObject()
    {

    }

    public void animatedObject()
    {

    }

    public void showWindow()
    {
        Window.SetActive(true);
    }

    public void hideWindow()
    {
        Window?.SetActive(false);
    }

}
