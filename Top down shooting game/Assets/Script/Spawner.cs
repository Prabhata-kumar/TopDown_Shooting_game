using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject Enemy;
    [SerializeField] private Transform[] spawnerPoins;
    private float timeBetweenSpawne;
    private float StartTimeSpawns;

    // Start is called before the first frame update
    void Start()                                                
    {
        timeBetweenSpawne = StartTimeSpawns;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBetweenSpawne <= 0)
        {
            int randPos = Random.Range(0, spawnerPoins.Length - 1);
            Instantiate(Enemy, spawnerPoins[randPos].position,Quaternion.identity);
            timeBetweenSpawne = StartTimeSpawns;
        }
        else
        {
            timeBetweenSpawne -= Time.deltaTime;
        }
    }
}
