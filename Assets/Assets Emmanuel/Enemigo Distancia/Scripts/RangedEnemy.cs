using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : MonoBehaviour
{
    public int Health = 100;
    public Animator animator;
    public AudioClip DeathAudioClip;
    [Range(0, 1)] public float DeathAudioVolume = 0.5f;

    public GameObject currentWeapon;
    public Transform spawnPoint;
    public float bulletSpeed;

    public void StartAttack()
    {
        GameObject bulletObj = Instantiate(currentWeapon, spawnPoint.transform.position, spawnPoint.transform.rotation);
        Rigidbody bulletRigid = bulletObj.GetComponent<Rigidbody>();
        bulletRigid.AddForce(bulletRigid.transform.forward * bulletSpeed);
        Destroy(bulletObj, 5f);
    }

    public void takeDamage(int amount)
    {
        Health -= amount;
        if (Health <= 0)
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