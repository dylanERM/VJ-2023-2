using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSystem : MonoBehaviour
{
    [SerializeField] GameObject weaponHolder;
    [SerializeField] 
    public GameObject weapon_1;
    [SerializeField] 
    public GameObject weapon_2;
    
    [SerializeField] CurrentWeaponUI cwUI;

    [SerializeField] Sprite weaponUI_1;
    [SerializeField] Sprite weaponUI_2;

    public GameObject currentWeapon;

    GameObject currentWeaponInHand;

    private void Start()
    {
        currentWeapon = weapon_1;
        cwUI.currentWeaponUI = weaponUI_1;

    }

    public void SwapWeapon()
    {
        if(weapon_2 != null)
        {
            if (currentWeapon == weapon_1)
            {
                Destroy(currentWeaponInHand);
                currentWeapon = weapon_2;
                DrawWeapon();
                cwUI.currentWeaponUI = weaponUI_2;
            }
            else
            {
                Destroy(currentWeaponInHand);
                currentWeapon = weapon_1;
                DrawWeapon();
                cwUI.currentWeaponUI = weaponUI_1;
            }
        }
    }
    public void DrawWeapon()
    {
        currentWeaponInHand = Instantiate(currentWeapon, weaponHolder.transform);
    }

    public void SheathWeapon()
    {
        Destroy(currentWeaponInHand);
    }

    public void StartAttack()
    {
        currentWeaponInHand.GetComponent<PlayerWeapon>().StartAttack();
    }

    public void EndAttack()
    {
        currentWeaponInHand.GetComponent<PlayerWeapon>().EndAttack();
    }
}
