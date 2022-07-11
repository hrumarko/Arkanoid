using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightPlatform : MonoBehaviour
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
            rb.AddForce(PlatformColliders.Direction("right") * Ball.speedBall);
        }
}
