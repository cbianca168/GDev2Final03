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

    //private float _timeUntilSpawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void Spawn()
    {
        
        StartCoroutine(SpawnZombiesForTime(10f));
    }

    
    private IEnumerator SpawnZombiesForTime(float duration)
    {
        float timeElapsed = 0f;

        while (timeElapsed < duration)
        {
            float _timeUntilSpawn = Random.Range(_minimumSpawnTime, _maximumSpawnTime);
            yield return new WaitForSeconds(_timeUntilSpawn);

            Instantiate(_zombiePrefab, transform.position, Quaternion.identity);
            Debug.Log("Zombie spawned!");

            timeElapsed += _timeUntilSpawn;
        }

        Debug.Log("Spawning ended, deactivating spawner.");
        gameObject.SetActive(false);
    }

}
