using System.Net;
using System.ComponentModel;

using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour
{     
    public GAME movement;
    
    

    
  
    void OnCollisionEnter(Collision collisionproperty)
    {
        if (collisionproperty.collider.tag  == "obstacle")
        {
                     movement.enabled=false;
                    SceneManager.LoadScene("gameover");
                
        }
        else if (collisionproperty.collider.tag  == "Player")
        {
                     movement.enabled=false;
                    SceneManager.LoadScene("win");
                
        }
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag  ("MainCamera"))
        {
            movement.enabled=false;
            SceneManager.LoadScene("gameover");
        }
    }



 
      }
