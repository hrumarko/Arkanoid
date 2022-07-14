using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   
    public static int speedBall = 50;
    public static Vector2 startPos = new Vector2(2, -8.7f);
    
    
    
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    
    
}
