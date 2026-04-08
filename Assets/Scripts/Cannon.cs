using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject projectile;
    public Transform firePoint;
    public Transform player;
    public float force = 10f;

    public float shootInterval = 5f;
    private float counter = 0f;

    void Update()
    {
        if (player == null) return;
      
        Vector3 dir = player.position - transform.position; // Calcula la dirección hacia el jugador
        dir.y = 0;

      

        counter += Time.deltaTime; // contadir 

        if (counter >= shootInterval)
        {
            Shoot();
            counter = 0f;
        }
    }

    void Shoot()
    {
        GameObject obj = Instantiate(projectile, firePoint.position, Quaternion.identity);

        Rigidbody rb = obj.GetComponent<Rigidbody>();

        Vector3 dir = (player.position - firePoint.position).normalized;

        rb.AddForce(dir * force, ForceMode.Impulse);
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward * 3);
    }
}
