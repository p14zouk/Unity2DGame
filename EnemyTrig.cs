using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class EnemyTrig : MonoBehaviour
{
    public StrawberryPicker Straw ;

    public TextMeshProUGUI textStrawberries;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Enemy"){
            Straw.Strawberry -=2;
            textStrawberries.text = Straw.Strawberry.ToString();
            if(Straw.Strawberry<=0){
                FindObjectOfType<GameManager>().EndGame();

            }
        }
    }
}
