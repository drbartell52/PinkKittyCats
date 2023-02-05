using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioSource LoseSound;
    // Start is called before the first frame update
    void Start()
    {
        LoseSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayLoseSound()
    {
        LoseSound.Play();
    }
}
