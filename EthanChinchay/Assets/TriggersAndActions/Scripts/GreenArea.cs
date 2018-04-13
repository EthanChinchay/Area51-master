using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenArea : MonoBehaviour {


    public Light Targetlight;
    public bool runUpdate;
    float timer = 0;

    void OnTriggerStay(Collider other) {

        if (Input.GetKeyDown(KeyCode.Space) && !runUpdate) {
            runUpdate = true;

        }
    }
    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player") && !runUpdate) {

            runUpdate = false;
        }
    }

    void Update() {
        if (runUpdate) {
            if (((int)Time.time) % 2 != 0) {
                Targetlight.enabled = Targetlight.enabled;
            }
        }
    }
}



