using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimento : MonoBehaviour
{
        public float velociade = 8f; 
        public float forçapulo =  10f;
        private float inputmovimento = 0f;
        private Rigidbody2D rig;
        private bool TaNoChao = false;
        public Rigidbody2D criar; 

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       inputmovimento = Input.GetAxis("Horizontal") ;
       rig.velocity = new Vector2(velociade * inputmovimento, rig.velocity.y);
       Pulo();
       if (Input.GetButton("Fire1")){

       }
    }
    void Pulo(){
        if(Input.GetButtonDown("Jump") && TaNoChao){
            rig.AddForce(new Vector2(0, forçapulo), ForceMode2D.Impulse);
        }
    }
    void OnCollisionEnter2D(Collision2D outroObj){
        if(outroObj.gameObject.CompareTag("Chao")){
            TaNoChao = true;
        }
    }
    void OnCollisionExit2D(Collision2D outroObj){
        if(outroObj.gameObject.CompareTag("Chao")){
            TaNoChao = false;
        }
    }
}
