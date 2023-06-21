using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkTrigger : MonoBehaviour
{
    MapController mc;
    public GameObject targetMap;
    void Start()
    {
        mc = FindObjectOfType<MapController>();   
    }

    // Update is called once per frame
    public void OnTriggerStay2D(Collider2D col){
        if (col.CompareTag("Player"))
        {
            mc.currentChunk = targetMap;
        }
    }
    public void OnTriggerExit2D(Collider2D col){
        if (col.CompareTag("Player"))
        {
            if(mc.currentChunk == targetMap){
                mc.currentChunk = null;
            }
        }
    }
}
