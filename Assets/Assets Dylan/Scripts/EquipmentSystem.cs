using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSystem : MonoBehaviour
{
    [SerializeField] GameObject weaponHolder;
    [SerializeField] GameObject weapon_1;
    [SerializeField] GameObject weapon_2;

    GameObject currentWeapon;

    GameObject currentWeaponInHand;

    private void Start()
    {
        currentWeapon = weapon_1;
    }

    public void SwapWeapon()
    {
        if (currentWeapon == weapon_1)
        {
            currentWeapon = weapon_2;
        }
        else
        {
            currentWeapon = weapon_1;
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
