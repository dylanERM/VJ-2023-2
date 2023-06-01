using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuetzalTeleport : MonoBehaviour
{
    public Transform player;
    public Transform quetzal1;
    public GameObject playerg;


    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            playerg.SetActive(false);
            player.position = quetzal1.position;
            playerg.SetActive(true);
        }
    }
}
