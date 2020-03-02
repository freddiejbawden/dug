using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetText : MonoBehaviour
{
    // Start is called before the first frame update
        public Text t1Temp;
                public Text t2Temp;


    public static Text t1;
    public static Text t2;

    void Start() {
      SetText.t1 = t1Temp;
      SetText.t2 = t2Temp;
    }

    public static void UpdateText(string text) {
      SetText.t1.text = text;
      SetText.t2.text = text;
    }
}
