using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongerAchievement : MonoBehaviour
{
    
    [SerializeField] float speed = 4f;
    int counts = 0;
    public GameObject longerObj;
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
            
            StartCoroutine(Longer());
            
        }
    }

    public IEnumerator Longer(){
        int count = 0;
        while(count <2)
        longerObj.SetActive(true);
        yield return new WaitForSeconds(4);
        longerObj.SetActive(false);
        count++;
        
    }
}
