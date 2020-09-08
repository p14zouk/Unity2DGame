using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CherryPicker : MonoBehaviour
{
    public float Cherry = 0;

    public TextMeshProUGUI textCherries;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.transform.tag == "Cherry"){
            Cherry ++;
            textCherries.text = Cherry.ToString();
            Destroy(other.gameObject);
        }
    }
}
