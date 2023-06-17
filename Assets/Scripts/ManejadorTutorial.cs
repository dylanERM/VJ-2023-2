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
        if (index < avisos.Length){
            avisos[index].SetActive(true);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            index++;
            if(index != avisos.Length ){
                avisos[index-1].SetActive(false);
                
            } else {
                 Destroy(caja);
            }
        }
        
    }
}
