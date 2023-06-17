using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWeapon : MonoBehaviour
{
    public int damageAmount = 40;
    public bool isAttacking;

    private void Start()
    {
        isAttacking = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "M_Enemy" && this.isAttacking)
        {
            other.GetComponent<MeleeEnemy>().takeDamage(damageAmount);
        }
        if (other.tag == "R_Enemy" && this.isAttacking)
        {
            other.GetComponent<RangedEnemy>().takeDamage(damageAmount);
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
