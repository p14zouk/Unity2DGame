using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpikeTrig : MonoBehaviour
{
    public StrawberryPicker Straw ;

    public TextMeshProUGUI textStrawberries;

   private void OnTriggerEnter2D(Collider2D other){
       if(other.transform.tag == "Spike"){
           Straw.Strawberry --;
           textStrawberries.text = Straw.Strawberry.ToString();
           if(Straw.Strawberry<=0){
               FindObjectOfType<GameManager>().EndGame();

           }
       }
   }
}
