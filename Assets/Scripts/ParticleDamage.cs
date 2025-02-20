using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDamage : MonoBehaviour
{
    public int damageAmount = 50;
    public string enemyTag = "Enemy";

    private void OnParticleCollision(GameObject other)
    {
       
        if (other.CompareTag(enemyTag))
        {
           
            EnemyHealth enemyHealth = other.GetComponent<EnemyHealth>();

            if(enemyHealth != null)
            {
                
                enemyHealth.TakeDamage(damageAmount);
            }
        }
    }
}
