using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefabrykat obiektu pocisku
    public float life = 3;
    public float spawnRadius = 1f; // Promieñ obszaru, w którym maj¹ byæ spawnowane nowe pociski

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
        Destroy(gameObject);

        // Spawn nowego pocisku
        SpawnBullet();
    }

    void SpawnBullet()
    {
        Vector3 spawnPosition = transform.position + Random.insideUnitSphere * spawnRadius;
        Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);
    }
}