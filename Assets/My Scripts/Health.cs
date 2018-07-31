using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {


    public Text life;
    public Image health;
    public float deltaHealth = 0.1f;
    public int lives = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        --lives;

        life.text = lives.ToString();

        if (lives <= 0)
        {
            Destroy(gameObject);
        }
        if (health.fillAmount > 0.0f)
        {
            health.fillAmount -= deltaHealth;

        
        }
    }
}
