using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _zombiePrefab;

    [SerializeField]
    private float _minimumSpawnTime;

    [SerializeField]
    private float _maximumSpawnTime;

    private float _timeUntilSpawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SetTimeUntilSpawn()
    {
        _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
    }

    private void Spawn()
    {
        SetTimeUntilSpawn();

        _timeUntilSpawn -= Time.deltaTime;

        if (_timeUntilSpawn <= 0 )
        {
            Instantiate(_zombiePrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
    }

}
