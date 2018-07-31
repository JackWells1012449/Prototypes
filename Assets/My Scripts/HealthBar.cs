using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Image health;
    public float deltaHealth = 0.1f;


    private void OnCollisionEnter(Collision collision)
    {
        if (health.fillAmount > 0.0f)
        {
            health.fillAmount -= deltaHealth;

        }

        
    }
}
