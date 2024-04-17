using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform bulletSpawn;
    public Transform rayVector;

    void Update()
    {
        RaycastHit hit;

        Debug.DrawLine(bulletSpawn.position, rayVector.position, Color.red);

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }

        if (Physics.Raycast(bulletSpawn.position, (rayVector.position - bulletSpawn.position).normalized, out hit))
        {
            if (hit.collider.gameObject.CompareTag("Box") && Input.GetMouseButtonDown(1))
            {
                Fire();
            }
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawn.position, bulletSpawn.rotation);

        bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 6.0f;

        Destroy(bullet, 2f);
    }
}