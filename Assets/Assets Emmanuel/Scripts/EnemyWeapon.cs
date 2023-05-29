using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public int damageAmount = 20;
    public bool isAttacking;

    private void Start()
    {
        isAttacking = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" && isAttacking)
        {
            other.GetComponent<StarterAssets.ThirdPersonController>().takeDamage(damageAmount);
        }

    }

    public void StartAttack()
    {
        isAttacking = true;
    }
    public void EndAttack()
    {
        isAttacking = false;
    }
}
