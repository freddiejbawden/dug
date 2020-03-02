using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pets : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject pets;
    void Start()
    {
        pets.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
         pets.SetActive(false);

        }
    }
    void OnTriggerEnter2D(Collider2D col) {
         pets.SetActive(true);
    }
}
