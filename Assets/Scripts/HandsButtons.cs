using System.Collections;
using System.Collections.Generic;

using UnityEditor.PackageManager.UI;

using UnityEngine;

public class HandsButtons : MonoBehaviour
{
    [SerializeField] GameObject Window;

    [SerializeField] GameObject sword;
   
    public void rotateObject()
    {
        //sword.transform.Rotate();    
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
