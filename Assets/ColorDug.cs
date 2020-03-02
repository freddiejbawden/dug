using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorDug : MonoBehaviour
{

    LinkedList<GameObject> dugList;
    // Start is called before the first frame update
    void Start()
    {

       Color();
    }

    void Color() {
       dugList = new LinkedList<GameObject>();

        dugList.AddLast(gameObject);
        populate(dugList, gameObject);

        GameObject[] dug = new GameObject[dugList.Count];
        dugList.CopyTo(dug, 0);

        Color cl = new Color(UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f), UnityEngine.Random.Range(0.0f, 1.0f));

        Debug.Log(cl.ToString());
        for(int i = 0; i < dugList.Count; i++){

            if(dug[i].GetComponent<SpriteRenderer>()){
                SpriteRenderer sr;
                sr = dug[i].GetComponent<SpriteRenderer>();
                sr.color = cl;
                Debug.Log("PAINTING");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) {
          Color();
        }
    }

    private void populate(LinkedList<GameObject> ll, GameObject go){
        
        foreach(Transform child in go.transform) {
            GameObject obj = child.gameObject;
            ll.AddLast(obj);
            populate(ll, obj);
        }
    }
}
