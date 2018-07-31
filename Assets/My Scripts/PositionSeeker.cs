using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSeeker : MonoBehaviour {
    public GameObject[] target;

    private Rigidbody rb;

    public float magnitude = 1.0f;
	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectsWithTag("Enemies");

        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = Vector3.Normalize(target[0].transform.position - transform.position);
        rb.AddForce(magnitude * direction);
	}
}
