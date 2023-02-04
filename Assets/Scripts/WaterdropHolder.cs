using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterdropHolder : MonoBehaviour
{
    public GameManager gameManager;

    void Update()
    {
        // JUST FOR TESTING
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpillTheBucket();
        }
    }

    // supposed to destroy both at the same time so both waterdrops fall at once
    public void SpillTheBucket()
    {
        Destroy(gameObject);  
    }
}