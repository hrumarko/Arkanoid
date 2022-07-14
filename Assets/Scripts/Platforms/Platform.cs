using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        if(Input.GetKeyDown(KeyCode.F)){
            WeaponOn();
        }
    }

    void Moving(){
        if(Input.GetKey(KeyCode.A)){
            
            transform.Translate(new Vector2(-1, 0) * Time.deltaTime * speed);
            if(!isMobility()){
                transform.position = new Vector2(-0.12f, this.transform.position.y);
            }
        }else if(Input.GetKey(KeyCode.D)){
            
             transform.Translate(new Vector2(1, 0) * Time.deltaTime * speed);
             if(!isMobility()){
                transform.position = new Vector2(4.1f, this.transform.position.y);
            }
        }
       
    }

    bool isMobility(){
        if(transform.position.x > 4.1f || transform.position.x < -0.12f){
            return false;
            
        }
        return true;
    }

    

    

    void WeaponOn(){
        StartCoroutine(FindObjectOfType<Weapon>().Shooting());
    }
}
