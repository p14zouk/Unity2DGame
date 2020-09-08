using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Rigidbody2D rd2d;
    public float falldelay;
    void start(){ 
    
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.collider.CompareTag("Player")){
            StartCoroutine(Fall());
        }
    }
    IEnumerator Fall(){
        yield return new WaitForSeconds(falldelay);
        GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
        GetComponent<Collider2D>().isTrigger = true;
        yield return 0;
    }
}
