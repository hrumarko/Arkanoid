using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftPlatform : MonoBehaviour
{
private void OnCollisionEnter2D(Collision2D other) {
    Rigidbody2D rb = other.gameObject.GetComponent<Rigidbody2D>();

    rb.AddForce(PlatformColliders.Direction("left") * Ball.speedBall);
}
}
