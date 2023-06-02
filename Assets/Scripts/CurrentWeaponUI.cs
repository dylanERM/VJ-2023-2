using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentWeaponUI : MonoBehaviour
{

    public Image arma;

    public Sprite currentWeaponUI;

    private void Update() {
        arma.sprite = currentWeaponUI;
    }
}
