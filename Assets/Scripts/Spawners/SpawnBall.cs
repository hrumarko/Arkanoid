using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    [SerializeField] Camera mainCamera;
    public GameObject ball;
    GameObject go;
    bool isMain = true;
    Vector2 pos;

    private void Start() {
        SpawnBalls();
    }
    private void Update() {
        if(isMain){
            Scope();
        }
    }

    public void SpawnBalls(){
        go = Instantiate(ball, Ball.startPos, Quaternion.identity);
        
    }

    public void Scope(){
        
        if(Input.GetMouseButton(0)){
            pos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
            

        }
        Debug.Log(pos);
        if(Input.GetMouseButtonUp(0)){
            Rigidbody2D rb = go.gameObject.GetComponent<Rigidbody2D>();
            float x = Ball.startPos.x - pos.x;
            float y = Ball.startPos.y - pos.y;

            Debug.Log($"{x}  i {y}");
            Vector2 forcePos = new Vector2(Ball.startPos.x - pos.x, Ball.startPos.y - pos.y);
            // Debug.Log("aaa" + forcePos);
            rb.AddForce(forcePos * 50);
            isMain = false;
        }
    }
}
