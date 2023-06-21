using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BtnFx : MonoBehaviour, ISelectHandler{


    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    void Update() // toca selected quando o botao eh pressionado
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            myFx.PlayOneShot(clickFx);
        }
    }

    public void OnSelect(BaseEventData eventData) //toca som ao passar pelo botao
    {
        myFx.PlayOneShot(hoverFx);
    }
}
