using System.Diagnostics;
using System.Net.Mime;
// using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
   public void ExitButton()
   {
    Application.Quit();

   }
   public void startgame()
   {
      SceneManager.LoadScene("scene-8");
   }
}
