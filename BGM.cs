using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour
{
    private static BGM backgroundmusic;

    void Awake(){
        if (backgroundmusic == null){
            backgroundmusic = this;
            DontDestroyOnLoad(backgroundmusic);
        }
        else {
            Destroy(gameObject);
        }
    }
}
