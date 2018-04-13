using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour {

    public GameObject objectSpawn;
    public bool spawnPossible = true;

    void OnTriggerStay(Collider other) {

        if (other.CompareTag("Follower")) {

            spawnPossible = false;


        }
    }
    void Update() {
        if (spawnPossible) {
            timer += Time.deltaTime;
        }
    }
}

    
