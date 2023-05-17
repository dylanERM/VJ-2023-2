using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeController : MonoBehaviour
{
    public int health = 100;
    public Animator animator;
    
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            animator.SetTrigger("die");
        }
        else
        {
            animator.SetTrigger("damaged");
        }
    }
}
