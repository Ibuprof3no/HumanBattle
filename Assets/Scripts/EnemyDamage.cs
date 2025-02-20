using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    
    public int damageAmount = 20;
    public GameObject Prometheus;

    public void OnTriggerEnter(Collider other)
    {

       if(other.CompareTag("Enemy"))
        {
            Prometheus.GetComponent<PlayerHealth>().PlayerTakeDamage(damageAmount);
        }
        Debug.Log("dañooooo");
    }
}
