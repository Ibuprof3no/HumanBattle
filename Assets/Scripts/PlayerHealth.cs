using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float maxHealth = 100;
    public float playerHealth;
    public GameObject YouDead;

    void Start()
    {
        playerHealth = maxHealth;
    }

    public void PlayerTakeDamage(int damage)
    {
        playerHealth = playerHealth - damage;
        if (playerHealth <= 0)
        {
            Die();
        }
    }

  private void Die()
    {
        if(YouDead != null)
        {
            YouDead.SetActive(true);
        }
    }
 
}