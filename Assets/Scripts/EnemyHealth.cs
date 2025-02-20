using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float maxHealth = 100f;
    public float currentHealth;
   
    private Animator animator;
    private bool isDead = false;
    void Start()
    {
        currentHealth = maxHealth;
        animator = GetComponent<Animator>();
    }
    


    public void TakeDamage(float amount)
    {
        if (isDead) return;
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            
            isDead = true;
            Die();
        }
    }

    void Die()
    {
        FindObjectOfType<DollyPausa>().IncrementarEnemigosMuertos();
        if (animator != null)
        {
            animator.SetBool("isdied", true);
        }

        Destroy(gameObject,2f);
    }
}
