using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float bounds = 2.20f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
    }

    void Moving(){
        if(Input.GetKey(KeyCode.A)){
            transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed);
            if(!isMobility()){
                transform.position = new Vector2(-bounds, this.transform.position.y);
            }
        }else if(Input.GetKey(KeyCode.D)){
             transform.Translate(new Vector2(1, 0) * Time.deltaTime * speed);
             if(!isMobility()){
                transform.position = new Vector2(bounds, this.transform.position.y);
            }
        }
       
    }

    bool isMobility(){
        if(transform.position.x > bounds || transform.position.x < -bounds){
            return false;
            
        }
        return true;
    }
}
