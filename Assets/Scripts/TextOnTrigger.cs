using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnTrigger : MonoBehaviour
{
    public GameObject textObject;


    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            textObject.SetActive(true);
            StartCoroutine(waiter());
        }
    }

    IEnumerator waiter()
    {
    
    yield return new WaitForSeconds(5);
    //textObject.SetActive(false);
    Destroy(textObject);
    }
}
