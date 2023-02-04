using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterdropHolder : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // JUST FOR TESTING
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Destroy(gameObject);
        }    
    }
    
}
