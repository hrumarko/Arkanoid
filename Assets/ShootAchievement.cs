using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAchievement : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    int counts = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Falling();
    }

    void Falling(){
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        
    }

    private void OnTriggerEnter2D(Collider2D other) {
        
        if(other.gameObject.tag == "Platform" && counts == 0){
            Destroy(this.gameObject);
            
            counts = 1;
            FindObjectOfType<Weapon>().ShootingCoroutine();
            
        }
    }
}
