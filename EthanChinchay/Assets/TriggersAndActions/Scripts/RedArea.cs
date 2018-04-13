using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedArea : MonoBehaviour {

    public Light Targetlight;

    void OnTriggerExit(Collider other) {

        Debug.Log("Exit");

        if (other.CompareTag("Player")) {

            Targetlight.enabled = false;
        }
    }
}
