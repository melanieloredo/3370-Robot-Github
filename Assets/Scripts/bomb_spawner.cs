using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb_spawner : MonoBehaviour
{

    public GameObject itemPrefab; //gameobject variable

    //**CLASS EXAMPLE**
    //public float r; //radius

    public float spawnInterval = 1.5f; // time between spawns
    public float spawnXMin, spawnXMax; // for screen width
    public float spawnY; // top of screen




    // Start is called before the first frame update
    void Start()
    {
        float screenHalfWidth = Camera.main.orthographicSize * Screen.width / Screen.height; //get camera dimensions for the screen
        spawnXMin = -screenHalfWidth;
        spawnXMax = screenHalfWidth;
        spawnY = Camera.main.orthographicSize + 1; // slightly above the top of screen


        //**CLASS EXAMPLE**
        //for(int i = 0; i < 10; i++)
        //{
        //  spawnObject();
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

            //**CLASS EXAMPLE**
            //spawnObject();

            StartCoroutine(SpawnBombs());
        }

    }
    //**CLASS EXAMPLE** tell unity how to create bombs
    /* void spawnObject()
     {
         Vector3 randomPos = Random.insideUnitCircle * r; //position random x, y within radius of this circle
         Instantiate(itemPrefab, randomPos, Quaternion.identity); //3 elements; what object?, which position?, Quat.identity // rotation to spawn at


     }*/


    IEnumerator SpawnBombs()
    {
        while (true)
        {
            SpawnBomb();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void SpawnBomb()
    {
        float randomX = Random.Range(spawnXMin, spawnXMax);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, 0);
        Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
    }

}
