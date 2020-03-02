using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class TitleScreen : MonoBehaviour
{
    public GameObject title;
    bool played =false;
    public SetText timer;
    public AudioSource audioSource;
        public AudioSource audioSource2;

    public CinemachineVirtualCamera followCam;
    public CinemachineVirtualCamera staticCam;

    public GameObject text;
    // Start is called before the first frame update
    void Start()
    {
      audioSource2.Play();
      text.SetActive(false);
      followCam.gameObject.SetActive(false);  
      staticCam.gameObject.SetActive(true);
    } 
   IEnumerator Timer()
    {
       
      yield return new WaitForSeconds(0.1f);
      title.SetActive(true);
      StartCoroutine(Timer2());
    }
     IEnumerator Timer2()
    {
       
      yield return new WaitForSeconds(2f);
      staticCam.gameObject.SetActive(false);
      followCam.gameObject.SetActive(true); 
      text.SetActive(true); 
    }
  void OnTriggerEnter2D(Collider2D col)
    {
      if (!played) {

      audioSource.time = 0.2f;
      audioSource.Play();
      played = true;
      }
      StartCoroutine(Timer());
    }
    // Update is called once per frame
    void Update()
    {
    
    }
}
