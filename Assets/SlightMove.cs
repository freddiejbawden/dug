using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlightMove : MonoBehaviour
{
    // Start is called before the first frame update
    float timeMove = 1f;
    float timeAcc = 1f;

    Vector3 dir;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (timeMove <= timeAcc) {
        // reset
        float x = Mathf.Cos(Random.Range(0.0f, 360f)) * Random.Range(0.5f, 1.5f);
        float y = Mathf.Sin(Random.Range(0.0f, 360f))  * Random.Range(0.5f, 1.5f);
        dir = transform.position + new Vector3(x,y, 0f);
        timeMove = 10f;
        timeAcc = 0f;
      } else {
        // transform.position = Vector2.Lerp(transform.position, transform.position + dir, Time.deltaTime / 25f);
        timeAcc += Time.deltaTime;
      }
      Vector2 pos = transform.position;

    }
}
