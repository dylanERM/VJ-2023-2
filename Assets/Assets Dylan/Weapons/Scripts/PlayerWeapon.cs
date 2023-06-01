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
        if (other.tag == "Enemy" && this.isAttacking)
        {
            other.GetComponent<MeleeEnemy>().takeDamage(damageAmount);
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
