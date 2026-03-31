using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float repeatDelay = 1.0f;
    private float nextDogTime;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextDogTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            nextDogTime = Time.time + repeatDelay;
        }
    }
}
