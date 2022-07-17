
using UnityEngine;

public class GAME : MonoBehaviour
{     public Rigidbody rb;
      public float moveforward = 2000f;
      public float moveright=500f;
      public float moveleft=-500f;


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,moveforward * Time.deltaTime);
    
        if (Input.GetKey("d"))
        {
            rb.AddForce(moveright* Time.deltaTime,0,0);
        }
    
          if (Input.GetKey("a"))
        {
            rb.AddForce(moveleft * Time.deltaTime,0,0);
        }

        

    
    
    
    }
}
