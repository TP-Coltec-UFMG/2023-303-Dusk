using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Back : MonoBehaviour, ISelectHandler
{
    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;

    public void GoBack(){
        myFx.PlayOneShot(clickFx);
        StartCoroutine(DelaySceneLoad());
    }
    IEnumerator DelaySceneLoad()
 {
     yield return new WaitForSeconds(1.0f);
     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
 }
 public void OnSelect(BaseEventData eventData)
    {
        myFx.PlayOneShot(hoverFx);
    }
}
