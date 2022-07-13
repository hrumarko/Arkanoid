using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformColliders : MonoBehaviour
{

    public static Vector2 Direction(string platform){
        
        if(platform == "right"){
           float x = 1;
           float y = Random.Range(0.4f, 1);
           Vector2 pos = new Vector2(x, y);
           return pos;
        }

        if(platform == "mid"){
           float x = Random.Range(-2, 2);
           float y = 1;
           Vector2 pos = new Vector2(x, y);
           
           return pos;
           
        }

        if(platform == "left"){
           float x = -1;
           float y = Random.Range(0.4f, 1);
           Vector2 pos = new Vector2(x, y);
           return pos;
        }

        return Vector2.zero;
    }
    
}
