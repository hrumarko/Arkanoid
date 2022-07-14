using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongerAchievements : MonoBehaviour
{
    int counts = 0;
    [SerializeField] float speed = 4f;
    
    void Update()
    {
        Falling();
    }

    // Update is called once per frame
    

    void Falling(){
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Platform" && counts == 0){
            
            FindObjectOfType<LongerPlatform>().LongestCoroutine();
            Destroy(this.gameObject);
            counts = 1;
            
            
        }
    }
   
}
