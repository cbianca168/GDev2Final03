using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        if(transform.position != player.transform.position)
        {
            transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * 10f);
        }
    }
}
