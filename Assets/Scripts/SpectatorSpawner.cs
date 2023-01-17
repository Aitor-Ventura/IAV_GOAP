using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpectatorSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _spectatorPrefab;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnSpectator), 0, Random.Range(2, 5));
    }
    
    private void SpawnSpectator()
    {
        StartCoroutine(nameof(DelayedSpawnSpectator));
    }
    
    private IEnumerator DelayedSpawnSpectator()
    {
        yield return new WaitForSeconds(Random.Range(0, 2));
        Instantiate(_spectatorPrefab, transform.position, Quaternion.identity);
    }
}
