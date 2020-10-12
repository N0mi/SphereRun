using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private float BombPerMinute = 30;
    private float FoodPerMinute = 20;


    private void Start()
    {
        Invoke("StartSpawns", 1f);
    }


    private IEnumerator SpawnFood()
    {
        while (true)
        {
            ObjectPooler.Instance.SpawnFromPool("Food", Random.onUnitSphere * 15f, Quaternion.identity);
            yield return new WaitForSeconds(60f / FoodPerMinute);
        }
    }


    IEnumerator SpawnBomb()
    {
        yield break;
    }


    private void StartSpawns()
    {
        StartCoroutine("SpawnFood");
    }


    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            ObjectPooler.Instance.SpawnFromPool("Food", Random.onUnitSphere * 15f, Quaternion.identity);
        }
    }
}
