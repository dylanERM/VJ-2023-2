using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : MonoBehaviour
{
    public int Health = 100;
    public Animator animator;
    public AudioClip DeathAudioClip;
    [Range(0, 1)] public float DeathAudioVolume = 0.5f;

    [SerializeField] GameObject weapon;

    GameObject currentWeapon;

    private void Start()
    {
        currentWeapon = weapon;
    }

    public void StartAttack()
    {
        currentWeapon.GetComponent<EnemyWeapon>().StartAttack();
    }

    public void EndAttack()
    {
        currentWeapon.GetComponent<EnemyWeapon>().EndAttack();
    }

    public void takeDamage(int amount)
    {
        Health -= amount;
        if(Health <= 0)
        {
            animator.SetTrigger("die");
            GetComponent<Collider>().enabled = false;
            AudioSource.PlayClipAtPoint(DeathAudioClip, transform.position, DeathAudioVolume);
        }
        else
        {
            animator.SetTrigger("damaged");
        }
    }
}
