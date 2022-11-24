using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timeBetweenDogs = 3;
    
    private float prevDogTime = 0f;
    

    // Update is called once per frame
    void Update() {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.realtimeSinceStartup - prevDogTime > timeBetweenDogs) {
            prevDogTime = Time.realtimeSinceStartup;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
