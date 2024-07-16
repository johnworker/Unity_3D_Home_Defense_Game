using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    public GameObject bulletPrefab;
    public Transform firePoint;

    void Update()
    {
        float move = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(move, 0, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
