using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour {
    public float magnitude = 100.0f;
    public float lifeTime = 5.0f;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().AddForce(magnitude * transform.forward);

        Destroy(gameObject, lifeTime);
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }


}
