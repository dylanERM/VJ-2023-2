using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TepoztopilliPickup : MonoBehaviour
{
    
    [SerializeField]
    GameObject tepoztopilli;

    private void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * 50);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<EquipmentSystem>().weapon_2 = tepoztopilli;
            Destroy(gameObject);
        }
        
    }
}
