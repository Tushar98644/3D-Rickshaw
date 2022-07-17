using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class control : MonoBehaviour{
 public void Resetscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
    }


      
}



   

