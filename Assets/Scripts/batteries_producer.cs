using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batteries_producer : MonoBehaviour
{
    public GameObject itemPrefab; //gameobject variable - take prefab
    public GameObject floor; //assign the floor object

    public float spawnInterval = 4f; //slower than the bombs


    //**CLASS EXAMPLE**
    //public float r; //radius to produce battery 


    // Start is called before the first frame update
    void Start()
    {
        
        //**CLASS EXAMPLE**
        /*for(int i = 0; i < 10; i++)
        {
          spawnObject();
        }*/

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            StartCoroutine(SpawnBatteries());
        }
        /*if (Input.GetKeyDown(KeyCode.B))
        {
            spawnObject();
        }*/
    }

    //**CLASS EXAMPLE**
    //tell unity how to create bombs
    /*void spawnObject()
    {
        Vector3 randomPos = Random.insideUnitCircle * r; //position random x, y within radius of this circle
        Instantiate(itemPrefab, randomPos, Quaternion.identity); //3 elements; what object?, which position?, Quat.identity // rotation to spawn at


    }*/

    IEnumerator SpawnBatteries()
    {
        while (true) // Infinite spawning
        {
            SpawnBattery();
            yield return new WaitForSeconds(spawnInterval); // Wait before spawning next battery
        }
    }

    void SpawnBattery()
    {
        if (floor == null) return;

        BoxCollider2D floorCollider = floor.GetComponent<BoxCollider2D>();
        if (floorCollider == null) return;

        float minX = floorCollider.bounds.min.x;
        float maxX = floorCollider.bounds.max.x;
        float spawnY = floorCollider.bounds.max.y; // Place battery right above the floor

        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, spawnY + 0.25f, 0);
        Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
    }

}
