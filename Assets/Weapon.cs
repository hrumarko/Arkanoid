using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    
    public GameObject bullet;

    private void Start() {
        
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Space)){
            StartCoroutine(Shooting());
        }
    }

    public IEnumerator Shooting(){
        int count = 0;

        while(count<10)
        {
        
        GameObject patron = Instantiate(bullet, transform.position, Quaternion.identity);
        patron.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 700);
        yield return new WaitForSeconds(0.1f);
        count++;
        }
            
        
    }
}
