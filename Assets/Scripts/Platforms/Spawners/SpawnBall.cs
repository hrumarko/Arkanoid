using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject ball;

    private void Start() {
        SpawnBalls();
    }

    public void SpawnBalls(){
        Instantiate(ball, Ball.startPos, Quaternion.identity);
    }
}
