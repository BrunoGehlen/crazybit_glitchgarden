using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    [SerializeField] GameObject defenderPrefab;
    [SerializeField] GameObject projectilePrefab;

    public void Shoot() {
        Instantiate(projectilePrefab, transform.position, transform.rotation);
    }
}
