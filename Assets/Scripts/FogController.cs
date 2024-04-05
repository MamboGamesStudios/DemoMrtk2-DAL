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


}
