using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectController : MonoBehaviour {
    public GameObject[] objects;
    private float _intervalSpawn = 1f;

	// Use this for initialization
	void Start () {
       
 
    }
	
	// Update is called once per frame
	void Update () {

       
         SpawnObj1();
         SpawnObj2();
         SpawnObj3();
        
           
    }
    public void SpawnObj1()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5.0f, 5), 5, 0);
        _intervalSpawn -= Time.deltaTime;
        if (_intervalSpawn <= 0)
        { 
         Instantiate(objects[0], spawnPosition, Quaternion.identity);
            _intervalSpawn = 1.5f;
        }


    }
    public void SpawnObj2()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5.0f, 5), 5, 0);
        _intervalSpawn -= Time.deltaTime;
        if (_intervalSpawn <= 0)
        {
            Instantiate(objects[1], spawnPosition, Quaternion.identity);
            _intervalSpawn = 3f;
        }

    }
    public void SpawnObj3()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-5.0f, 5), 5, 0);
        _intervalSpawn -= Time.deltaTime;
        if (_intervalSpawn <= 0)
        {
            Instantiate(objects[2], spawnPosition, Quaternion.identity);
            _intervalSpawn = 6f;
        }
    }
}
