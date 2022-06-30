using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedoplayer : MonoBehaviour
{
    // Start is called before the first frame update
  
public static bool TaVoando = true; 
    void OnCollisionExit2D(Collision2D colide)
    {
       if(colide.gameObject.tag == "Chao")
       {
           TaVoando = true;
           
       } 
    }
     void OnCollisionEnter2D(Collision2D colide)
    {
       if(colide.gameObject.tag == "Chao")
       {
           TaVoando = false;
           //animate.SetBool("Pulando", false);
       } 
      if(colide.gameObject.tag == "Enemy")
      {
          transform.position = new Vector3(306,-47,0);
          //Destroy(gameObject);
      }

    }
}
