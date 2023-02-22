using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject cubePrefab;
    public float numberOfPickups;

    // Start is called before the first frame update
    void Start()
    {
        for (float i = 0; i <= numberOfPickups; i ++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-20, 20), Random.Range(1, 5), Random.Range(-20, 20));
            Instantiate(cubePrefab, randomSpawnPosition, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
