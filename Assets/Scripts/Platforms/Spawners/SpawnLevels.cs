using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnLevels : MonoBehaviour
{
    public GameObject[] levels;
    GameObject level;
    int rand;
    
    public GameObject winPanel;
    bool isWin = false;
     

    private void Start() {
        SpawnLevel();   
    }
    void Update(){
        Winning();
    }

    void SpawnLevel(){
        rand = Random.Range(0, levels.Length);
        level = Instantiate(levels[rand]);
    }

    void Winning(){

        if(level.transform.childCount == 0 && !isWin){
            Time.timeScale = 0;
            winPanel.SetActive(true);
            isWin = true;
        }

        if(isWin && Input.anyKey){
            Time.timeScale = 1;
            
            winPanel.SetActive(false);
            
            isWin = false;
            SceneManager.LoadScene(0);
        }
    }
}
