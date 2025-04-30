using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZBarrier01 : MonoBehaviour
{
   
    public ZombieSpawner _zSpawner01;
    public ZombieSpawner _zSpawner02;
    public ZombieSpawner _zSpawner03;
    public ZombieSpawner _zSpawner04;


    // Start is called before the first frame update
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _zSpawner01.Spawn();
            _zSpawner02.Spawn();
            _zSpawner03.Spawn();
            _zSpawner04.Spawn();

            gameObject.SetActive(false);
        }
    }
}
