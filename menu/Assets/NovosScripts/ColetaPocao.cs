using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaPocao : MonoBehaviour
{

    [SerializeField] private Text scoreTxt;
    [SerializeField] private Text portaTxt;
    [SerializeField] private AudioSource som;
    [SerializeField] private AudioSource somPorta;
    [SerializeField] private AudioSource somPorta2;
    [SerializeField] private AudioSource somParede;
    [SerializeField] private AudioSource walk;
    private Animation anima;
    private int score; 

    public int Score{
        get{ return score; }
        set{ score = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        scoreTxt.text = "" + Score;
        portaTxt.enabled = false;
        anima = GetComponent<Animation>();
    }

    void Update(){

        if(Input.GetKeyDown(KeyCode.Space)){
            somPorta.Play();
        }

        if(anima.isPlaying){
            walk.Play();
        }else{
            walk.Stop();
        }
        
    }

    public void OnCollisionEnter2D(Collision2D collision2D){

        if(collision2D.gameObject.tag == "potion"){

            Score++;
            som.Play();
            scoreTxt.text = ""+ Score;
            Destroy(collision2D.gameObject);

            if(Score >= 5){
                portaTxt.enabled = true;
                somPorta.Play();
            }

        }

        if(collision2D.gameObject.tag == "door"){
            somPorta2.Play();
        }

        if(collision2D.gameObject.tag == "wall"){
            somParede.Play();
        }
    }
}
