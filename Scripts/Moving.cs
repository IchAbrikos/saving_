using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Moving : MonoBehaviour
{
  
    new private Rigidbody2D rigidbody;
 
    private SpriteRenderer sprite;
    
    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
   
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    
     void Update()
    {
       if(Input.GetKey(KeyCode.D))
       {
           transform.Translate(0.01f,0f,0f);
       }
    
    if(Input.GetKey(KeyCode.A))
       {
           transform.Translate(-0.01f,0f,0f);
       }
      
      if(Input.GetKey(KeyCode.Space))
       {
           transform.Translate(0f,0.05f,0f);
       }
    }
}