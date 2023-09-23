using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float xPosRange = 13;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.E))
        {
            float randXPos = Random.Range(-xPosRange, xPosRange);
            int animalPrefabsIndex = Random.Range(0, animalPrefabs.Length);
            Vector3 RandPos = new Vector3(randXPos, 0, 21);
            Instantiate(animalPrefabs[animalPrefabsIndex], RandPos, animalPrefabs[animalPrefabsIndex].transform.rotation);
        }
    }
}
