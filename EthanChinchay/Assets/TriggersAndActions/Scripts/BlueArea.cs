using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueArea : MonoBehaviour {

    public Light Targetlight;

    void OnTriggerEnter (Collider other) {

        Debug.Log("Enter");

        if (other.CompareTag("Player")) {

            Targetlight.enabled = true;
        }
    }
}
