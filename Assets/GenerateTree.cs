using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTree : MonoBehaviour
{
    public GameObject leaves;
    // Start is called before the first frame update
    void Start()
    {
      GameObject root = Instantiate(new GameObject("Root"), transform.position, Quaternion.identity);
      root.transform.parent = transform;
      root.transform.localPosition = new Vector2(0f, Random.Range(3f, 4f));      
        for (int i = 0; i < 10; i++) {
          float c = Random.Range(0.5f, 1f);
          Color color = new Color(0f,c,0f); 
          for (float j = 0f; j < Mathf.Floor(Random.Range(0f, 5f)); j++) {
            float x = Mathf.Cos(Random.Range(0.0f, 360f)) * Random.Range(0.5f, 2f);
            float y = Mathf.Sin(Random.Range(0.0f, 360f))  * Random.Range(0.5f, 2f);
            float z = (Random.Range(0f, 1f) < 0.9f) ? 0f : -1f; 
            Vector3 position = root.transform.position + new Vector3(x,y,z);
            GameObject newCloud = Instantiate(leaves, position, Quaternion.identity);
            newCloud.transform.parent = transform;
            SpriteRenderer sr = newCloud.GetComponent<SpriteRenderer>();
            sr.color = color;
          }
        }
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
