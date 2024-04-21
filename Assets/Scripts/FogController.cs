using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FogController : MonoBehaviour
{
    private float density;

    [SerializeField] PinchSlider slider;


    public void ChangeFog()
    {
        RenderSettings.fogDensity = slider.SliderValue/10;
    }

    public void increaseFog()
    {
        RenderSettings.fogDensity += 0.5f / 10;
    }

    public void reduceFog()
    {
        RenderSettings.fogDensity -= 0.5f / 10;
    }


}
