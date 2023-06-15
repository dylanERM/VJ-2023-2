using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuetzalRest : MonoBehaviour
{
    public GameObject playerg;

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Player")){
            int hp = playerg.GetComponent<StarterAssets.ThirdPersonController>().Health;
            int restval = hp + 30;
            if (restval > 100){
                playerg.GetComponent<StarterAssets.ThirdPersonController>().healthBar.setHealth(100);
            }else{
                playerg.GetComponent<StarterAssets.ThirdPersonController>().healthBar.setHealth(restval);
            }
            
        }
    }
}
