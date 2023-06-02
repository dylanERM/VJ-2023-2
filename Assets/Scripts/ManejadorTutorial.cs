using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManejadorTutorial : MonoBehaviour
{   
    public GameObject[] avisos;
    private int index = 0;

    public GameObject caja;

    // Update is called once per frame
    void Update()
    {  

        avisos[index].SetActive(true);
           


        if(Input.GetKeyDown(KeyCode.Space))
        {
            index++;
            avisos[index-1].SetActive(false);
            if(index == avisos.Length){
                Destroy(caja);
            }
        }
        
    }
}
