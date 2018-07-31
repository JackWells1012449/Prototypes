using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

    private int numberOfPickups = 0;
    private int totalValue = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            ++numberOfPickups;
        Debug.Log("number of pick ups: " + numberOfPickups);

            totalValue += other.GetComponent<PickUp>().value;
            Debug.Log("total value = " + totalValue);


            other.gameObject.SetActive(false);
        }

    }
}
