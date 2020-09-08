using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StrawberryPicker : MonoBehaviour
{
    public float Strawberry = 3;

    public TextMeshProUGUI textStrawberries;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Strawberry"){
            if(Strawberry<3){
                Strawberry ++;
            }
            textStrawberries.text = Strawberry.ToString();
            Destroy(other.gameObject);
        }
    }
}