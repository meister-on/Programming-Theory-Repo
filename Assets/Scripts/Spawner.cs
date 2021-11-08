using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject flower1Prefab;
    public GameObject flower2Prefab;
    public GameObject flower3Prefab;
    private float range = 8;
    private void Awake()
    {
        SpawningFlower();
    }

    // Start is called before the first frame update
    void Start()
    {
        //SpawningFlower();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawningFlower()
    {
        transform.rotation = Quaternion.Euler(90, 0, 0);
        for (int i=0; i < 5; i++)
        {
           
            Vector3 pos1 = new Vector3(Random.Range(-range, range), 1.68f, Random.Range(-range, range));
            Instantiate(flower1Prefab, pos1, transform.rotation);
            Vector3 pos2 = new Vector3(Random.Range(-range, range), 1.68f, Random.Range(-range, range));
            Instantiate(flower2Prefab, pos2, transform.rotation);
            Vector3 pos3 = new Vector3(Random.Range(-range, range), 1.68f, Random.Range(-range, range));
            Instantiate(flower3Prefab, pos3, transform.rotation);
        }
       
    }
    
}
