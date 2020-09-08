﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed;
    public bool MoveRight;
    public Transform groundDetection;
    void Update (){
        if(MoveRight){
            transform.Translate(2*Time.deltaTime*speed , 0,0);
            transform.localScale= new Vector2 (1,1);
        }
        else{
            transform.Translate(-2*Time.deltaTime*speed , 0,0);
            transform.localScale= new Vector2 (-1,1);
        }
    }
    void OnTriggerEnter2D(Collider2D trig) {
        if(trig.gameObject.CompareTag("Turn")){
            if (MoveRight){
                MoveRight=false;
            }
            else{
                MoveRight=true;
            }
        }
    }
}
