using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Woof : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) && !audioSource.isPlaying) {
          audioSource.time = 0.2f;
          audioSource.Play();
        }
    }
}
