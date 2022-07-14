using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();
        
        rb.AddForce(PlatformColliders.Direction("mid")* Ball.speedBall/2);
}
}
