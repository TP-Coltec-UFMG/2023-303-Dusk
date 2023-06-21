using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    // Start is called before the first frame update
    public float movSpeed = 5; 
    public float lastHorizontalVector;
    public float lastVerticalVector;
    Rigidbody2D rb;
    
    public Vector2 moveDir;
    void Start()
    {
     rb = GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        InputManagment(); 
    }

    void FixedUpdate(){
        Move(); 
    }

    void InputManagment(){
         float moveX = Input.GetAxisRaw("Horizontal");
         float moveY = Input. GetAxisRaw("Vertical");
         moveDir = new Vector2(moveX, moveY).normalized;
         if(moveDir.x != 0){
            lastHorizontalVector = moveDir.x;
         }
         if(moveDir.y != 0){
            lastVerticalVector = moveDir.y;
         }
    }

    void Move(){
        rb.velocity = new Vector2(moveDir.x * movSpeed, movSpeed * moveDir.y); 
    }
}
