using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseZone : MonoBehaviour
{
    public GameObject panel;
    bool isLose = false;
    private void Update() {
        ResetGame();
    }
    private void OnCollisionEnter2D(Collision2D other) {
        Destroy(other.gameObject);
        StopGame();
        

    }

    void StopGame(){
        Time.timeScale = 0;
        isLose = true;
        panel.SetActive(true);
    }

    void ResetGame(){
        
        if(Input.anyKey && isLose){
            Time.timeScale = 1;
            panel.SetActive(false);
            SceneManager.LoadScene(0);
            isLose = false;
        }
    }
}
