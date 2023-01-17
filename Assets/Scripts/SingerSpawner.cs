using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingerSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _singerPrefab;

    private void OnEnable()
    {
        LeaveSingerCampus.OnSingerDestroyed += SpawnSinger;
    }

    private void OnDisable()
    {
        LeaveSingerCampus.OnSingerDestroyed -= SpawnSinger;
    }

    private void Start()
    {
        SpawnSinger();
    }

    public void SpawnSinger()
    {
        Instantiate(_singerPrefab, transform.position, Quaternion.identity);
    }
}
