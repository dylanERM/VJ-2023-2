using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbreZonaDos : MonoBehaviour
{
    public Transform abierto;
    public GameObject rampa;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            //rampa.SetActive(false);
            //rampa.transform.position = abierto.position;
            rampa.SetActive(true);
        }
    }
}