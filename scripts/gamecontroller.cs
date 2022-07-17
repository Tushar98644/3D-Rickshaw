using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public gameoverscreen gameoverscreen;
    int maxplatform=0;
    
    public void GAMEOVER()
    {
         gameoverscreen.Setup(maxplatform);
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
