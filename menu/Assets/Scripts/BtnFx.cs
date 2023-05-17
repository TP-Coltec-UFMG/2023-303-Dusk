using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnFx : MonoBehaviour, ISelectHandler{


    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            myFx.PlayOneShot(clickFx);
        }
    }



    public void OnSelect(BaseEventData eventData)
    {
        myFx.PlayOneShot(hoverFx);
    }
}
