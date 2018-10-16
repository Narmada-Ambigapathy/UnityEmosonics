﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightness_Slider : MonoBehaviour {
    float rgbValue = 0.5f;
    // Use this for initialization
    void update() {
        RenderSettings.ambientLight = new Color(rgbValue, rgbValue, rgbValue, 1);
    }


	void OnGUI()
    {
        rgbValue = GUI.HorizontalSlider(new Rect (Screen.width/2 - 50, 90, 100, 30),rgbValue,0f,1.0f);
        RenderSettings.ambientLight = new Color(rgbValue, rgbValue, rgbValue, 1);

    }
}
