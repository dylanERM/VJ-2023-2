using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressAnyButton : MonoBehaviour
{
    public GameObject opciones;
    public GameObject pressEnter;

    void Update()
    {
        if (Input.anyKey)
        {
            pressEnter.SetActive(false);
            opciones.SetActive(true);
        }
    }
}
