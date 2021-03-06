﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cloud;
    public float cloudSpeed;
    public float xLim;
    void Start()
    {
      Vector2 oldPos = transform.position;
      for (int i = 0; i < 5; i++) {
        float c = Random.Range(0.8f + (0.2f / 5) * i, 0.8f+ (0.2f / 5) * (i + 1));
        Color color = new Color(c,c,c); 
        for (float j = 0f; j < Mathf.Floor(Random.Range(0f, 5f)); j++) {
          float x = Mathf.Cos(Random.Range(0.0f, 360f)) * Random.Range(0.5f, 1.5f);
          float y = Mathf.Sin(Random.Range(0.0f, 360f))  * Random.Range(0.5f, 1.5f);
          Vector2 position = oldPos + new Vector2(x,y);
          GameObject newCloud = Instantiate(cloud, position, Quaternion.identity);
          newCloud.transform.parent = transform;
          color.a = Random.Range(0.5f, 0.7f);
          SpriteRenderer sr = newCloud.GetComponent<SpriteRenderer>();
          sr.color = color;
          oldPos = position;
        }
      }
     
    }

    // Update is called once per frame
    void Update()
    {
      Vector2 pos =  transform.position;
      pos.x += Time.deltaTime * cloudSpeed;
      transform.position = pos;
      if (transform.position.x > xLim) {
        Destroy(gameObject);
      }
    }
}
