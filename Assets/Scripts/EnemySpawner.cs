using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool spawn = true;
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 3f;
    [SerializeField] Attacker attackerPrefab;

    IEnumerator Start() {

        while (spawn) {
            yield return new WaitForSeconds(UnityEngine.Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnAttacker();
        }
    }

    private void SpawnAttacker() {
        Instantiate(attackerPrefab,transform.position, transform.rotation);
    }
}
