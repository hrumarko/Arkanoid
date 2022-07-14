using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    int health =2;
    public GameObject effect;
    public GameObject achieve;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(health<=0){
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ball"){
            Destroy(this.gameObject);
            Instantiate(effect, this.transform.position, Quaternion.identity);
            
            if(Random.value<0.1){
                Instantiate(achieve, transform.position, Quaternion.identity);
            }
        }

        if(other.gameObject.TryGetComponent<Bullet>(out Bullet bullet)){
            health--;
        }
    }
}
