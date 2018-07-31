using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewHealthBar : MonoBehaviour {
    public GameObject[] target;

    public Image health;
    public float deltaHealth = 0.1f;


    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        target = GameObject.FindGameObjectsWithTag("Enemies");

        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        target = GameObject.FindGameObjectsWithTag("Enemies");

        if (health.fillAmount > 0.0f)
        {
            
            health.fillAmount -= deltaHealth;

        }

    }

}
