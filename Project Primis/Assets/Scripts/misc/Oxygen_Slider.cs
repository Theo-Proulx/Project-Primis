﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Oxygen_Slider : MonoBehaviour
{ 

    public Slider slider;
    public Gradient air;
    public void SetMaxOxygen(int Oxygen)
    {
        slider.maxValue = Oxygen;
        slider.value = Oxygen;
    }



    public void SetOxygen (int Oxygen)
    {
        slider.value = Oxygen;
    }


}
