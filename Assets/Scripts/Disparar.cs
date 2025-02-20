using UnityEngine;

public class Disparar : MonoBehaviour
{
    [Header("Flamethrower Settings")]
    public ParticleSystem waterParticles;
    [SerializeField]
    private float damagePerSecond = 10f;

    public float range = 5f;
    public float coneAngle = 45f;
    public int rayCount = 10; // Número de raycasts para formar el cono
    public LayerMask enemyLayer;
    public Camera playerCamera; // Referencia a la cámara para el control del mouse

   

    void Start()
    {
        // Asegurarnos de que el sistema de partículas esté configurado para detectar colisiones
        var collisionModule = waterParticles.collision;
        collisionModule.enabled = true;
        collisionModule.type = ParticleSystemCollisionType.World;
        collisionModule.collidesWith = enemyLayer; // Especificar qué capas deben ser detectadas por las partículas
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RotateTowardsMouse();

            waterParticles.Play();
        }
       if(Input.GetMouseButtonUp(0))
        {
            waterParticles.Stop();
        }
    }

    void RotateTowardsMouse()
    {
        Ray ray = playerCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo))
        {
            Vector3 targetDirection = (hitInfo.point - transform.position).normalized;
            transform.forward = targetDirection;
            waterParticles.transform.forward = targetDirection;
        }
    }

  
}
