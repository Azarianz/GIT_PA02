using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public GameObject[] spawnobject;
    public int spawnIndex;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObjectSpawning", 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ObjectSpawning()
    {
        spawnIndex = Random.Range(0, spawnobject.Length);
        Vector3 randomX = new Vector3(Random.Range(-2, 3), transform.position.y, transform.position.z);
        Instantiate(spawnobject[spawnIndex], randomX, Quaternion.identity);
    }
}
