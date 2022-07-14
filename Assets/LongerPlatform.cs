using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongerPlatform : MonoBehaviour
{
    public GameObject longerObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LongestCoroutine(){
        StartCoroutine(Longest());
    }

    private IEnumerator Longest(){
        
        longerObj.SetActive(true);
        yield return new WaitForSeconds(5);
        longerObj.SetActive(false);
    }
}
