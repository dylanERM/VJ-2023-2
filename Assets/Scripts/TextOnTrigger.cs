using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOnTrigger : MonoBehaviour
{
    public GameObject textObject;

    private bool isTriggered = false;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player") && !isTriggered){
            textObject.SetActive(true);
            StartCoroutine(waiter());
            isTriggered = true;
        }
    }

    IEnumerator waiter()
    {
    
    yield return new WaitForSeconds(5);
    textObject.SetActive(false);
    //sDestroy(textObject);
    }
}
