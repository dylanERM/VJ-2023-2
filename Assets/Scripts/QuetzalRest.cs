using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuetzalRest : MonoBehaviour
{
    public GameObject playerg;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            playerg.GetComponent<StarterAssets.ThirdPersonController>().healPlayer();   
        }
    }
}
