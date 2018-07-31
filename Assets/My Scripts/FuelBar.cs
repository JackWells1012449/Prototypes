using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour {

    public Image fuel;
    public float deltaFuel = 0.1f;


    private void OnCollisionEnter(Collision collision)
    {
        if (fuel.fillAmount < 1.0f)
        {
            fuel.fillAmount += deltaFuel;

        }


    }
}
