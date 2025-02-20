using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class DollyPausa : MonoBehaviour
{
    public bool pausado = false;
    public GameObject Prometheus;
    

    public int enemigosAMatar = 3;
    public int enemigosMatados = 0;
    private object other;

    void Update()
    {
        if(enemigosMatados == enemigosAMatar)
        {
            Prometheus.GetComponent<CinemachineDollyCart>().m_Speed = 10;
            
        }
    }

    public void IncrementarEnemigosMuertos()
    {
        if(pausado)
        {
            enemigosMatados++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Ha entrado");
            pausado = true;
            Prometheus.GetComponent<CinemachineDollyCart>().m_Speed = 0;
        }
       
    
    }
}
