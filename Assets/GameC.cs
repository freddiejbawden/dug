using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameC : MonoBehaviour
{
    // Start is called before the first frame update
    float time;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.R)) {
        time = 0f;
      }
      SetText.UpdateText(time.ToString("0.##"));
      time += Time.deltaTime;
    }
}
