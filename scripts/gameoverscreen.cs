using System.Security.Cryptography.X509Certificates;
using System.Runtime.InteropServices.ComTypes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameoverscreen : MonoBehaviour
{   
       public Text pointsText;
    
     public void Setup(int score)
    {
        gameObject.SetActive(true);
        pointsText.text=score.ToString();
    }

    public void RESTARTGAME()
    {
        SceneManager.LoadScene("scene-8");
    }
    public void MAINMENU()
    {
        SceneManager.LoadScene("Main menu");
    }
} 
