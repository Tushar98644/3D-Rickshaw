

using UnityEngine;
using UnityEngine.UI;

public class mainscore1 : MonoBehaviour
{
    public Transform mainplayer;
    public Text scoremain;


    // Update is called once per frame
    void Update()
    {
        scoremain.text = mainplayer.position.z.ToString("0");
    }
} 
