using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float chance;
    public GameObject cloud;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Random.Range(0f, 1f) < chance) {
        Instantiate(cloud, transform.position, Quaternion.identity);
      }
    }
}
