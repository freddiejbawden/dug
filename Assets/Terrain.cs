using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Terrain : MonoBehaviour
{
    public const int LENGTH = 10000;
    public const int SCAN_RADIUS = 200;

    float[] heightmap = new float[LENGTH];
    GameObject[] heightGOs = new GameObject[LENGTH];
    GameObject go;
    GameObject b1;
    Rigidbody2D rb;

    public Sprite Square;

    private GameObject ass;
    private GameObject head;

    private GameObject bd1;
    private GameObject bd2;
    private GameObject bd3;
    private GameObject bd4;
    private GameObject bd5;
    private GameObject bd6;
    private GameObject bd7;
    private GameObject bd8;

    private GameObject fpaw;
    private GameObject bpaw;
    private GameObject fpaw2;
    private GameObject bpaw2;



    void Start()
    {

        InitDugg();

    }
    
    void Update ()
    {


        // Dug controls
       float torq = 12.5f;
       float feet = 30f;
        if(Input.GetKey(KeyCode.W)){
            Rigidbody2D rb1 = bd1.GetComponent<Rigidbody2D>();
            rb1.AddTorque(torq*2);
            Rigidbody2D rb2 = bd2.GetComponent<Rigidbody2D>();
            rb2.AddTorque(torq*2);
            Rigidbody2D rb3 = bd3.GetComponent<Rigidbody2D>();
            rb3.AddTorque(torq*2);
            Rigidbody2D rb4 = bd4.GetComponent<Rigidbody2D>();
            rb4.AddTorque(torq*2);
            Rigidbody2D rb5 = bd5.GetComponent<Rigidbody2D>();
            rb5.AddTorque(torq*2);
            Rigidbody2D rb6 = bd6.GetComponent<Rigidbody2D>();
            rb6.AddTorque(torq*2);
            Rigidbody2D rb7 = bd7.GetComponent<Rigidbody2D>();
            rb7.AddTorque(torq*2);
            Rigidbody2D rb8 = bd8.GetComponent<Rigidbody2D>();
            rb8.AddTorque(torq*2);
        }else if(Input.GetKey(KeyCode.S)){
            Rigidbody2D rb1 = bd1.GetComponent<Rigidbody2D>();
            rb1.AddTorque(-torq);
            Rigidbody2D rb2 = bd2.GetComponent<Rigidbody2D>();
            rb2.AddTorque(-torq);
            Rigidbody2D rb3 = bd3.GetComponent<Rigidbody2D>();
            rb3.AddTorque(-torq);
            Rigidbody2D rb4 = bd4.GetComponent<Rigidbody2D>();
            rb4.AddTorque(-torq);
            Rigidbody2D rb5 = bd5.GetComponent<Rigidbody2D>();
            rb5.AddTorque(-torq);
            Rigidbody2D rb6 = bd6.GetComponent<Rigidbody2D>();
            rb6.AddTorque(-torq);
            Rigidbody2D rb7 = bd7.GetComponent<Rigidbody2D>();
            rb7.AddTorque(-torq);
            Rigidbody2D rb8 = bd8.GetComponent<Rigidbody2D>();
            rb8.AddTorque(-torq);
        }


        if (Input.GetKey(KeyCode.A)){
            Rigidbody2D rb = fpaw.GetComponent<Rigidbody2D>();
            rb.AddTorque(feet);
        }else if (Input.GetKey(KeyCode.D)){
            Rigidbody2D rb = fpaw.GetComponent<Rigidbody2D>();
            rb.AddTorque(-feet);
        }if (Input.GetKey(KeyCode.D)){
            Rigidbody2D rb = bpaw.GetComponent<Rigidbody2D>();
            rb.AddTorque(-feet);
        }else if (Input.GetKey(KeyCode.A)){
            Rigidbody2D rb = bpaw.GetComponent<Rigidbody2D>();
            rb.AddTorque(feet);
        }


        //rb.AddTorque(-100);
    }

    private void InitDugg(){

        go = GameObject.Find("dognew");
        b1 = GameObject.Find("bone_1");
        ass = GameObject.Find("bone_7");
        head = GameObject.Find("bone_2");
        fpaw = GameObject.Find("bone_15");
        bpaw = GameObject.Find("bone_10");
        fpaw2 = GameObject.Find("bone_16");
        bpaw2 = GameObject.Find("bone_11");

        bd1 = GameObject.Find("bone_1");
        bd2 = GameObject.Find("bone_2");
        bd3 = GameObject.Find("bone_3");
        bd4 = GameObject.Find("bone_4");
        bd5 = GameObject.Find("bone_5");
        bd6 = GameObject.Find("bone_6");
        bd7 = GameObject.Find("bone_7");
        bd8 = GameObject.Find("bone_8");

    //    go = Instantiate(dognew, new Vector3 (0, 0, 0), Quaternion.identity);
          //    rb = go.AddComponent<Rigidbody2D>();
    //    rb.freezeRotation = true;

        LinkedList<GameObject> doge = new LinkedList<GameObject>();
        doge.AddLast(b1);
        populate(doge, b1);

        Debug.Log("" + doge.Count);

        GameObject[] dogeArray = new GameObject[doge.Count];
        doge.CopyTo(dogeArray, 0);

        for(int i = 0; i < doge.Count; i++){

            Physics2D.IgnoreCollision(dogeArray[i].GetComponent<Collider2D>(), bpaw.GetComponent<Collider2D>());
            Physics2D.IgnoreCollision(dogeArray[i].GetComponent<Collider2D>(), fpaw.GetComponent<Collider2D>());
            
            Physics2D.IgnoreCollision(dogeArray[i].GetComponent<Collider2D>(), bpaw2.GetComponent<Collider2D>());
            Physics2D.IgnoreCollision(dogeArray[i].GetComponent<Collider2D>(), fpaw2.GetComponent<Collider2D>());
            //for(int j = i+1; j < doge.Count; j++){
                //if(dogeArray[i].GetComponent<Collider2D>() && dogeArray[j].GetComponent<Collider2D>())
                //Physics2D.IgnoreCollision(dogeArray[i].GetComponent<Collider2D>(), dogeArray[j].GetComponent<Collider2D>());
            //}
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