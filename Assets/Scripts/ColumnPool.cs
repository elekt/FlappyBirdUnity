using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColumnPool : MonoBehaviour {

    public int columnPoolSize = 5;
    public GameObject columnPrefab;
    public float spawnRate = 4f;
    public float columnMin = -1f;
    public float columnMax = 3.5f;

    GameObject[] columns;
    Vector2 objectPoolPosition = new Vector2(-15f, -25f);
    float timeSinceLastSpawn = 0f;
    float spawnXPosition = 10f;
    int currentColumn = 0;


    void Start()
    {
        columns = new GameObject[columnPoolSize];
        for (int i = 0; i < columnPoolSize; ++i) 
        {
            columns[i] = (GameObject)Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
        }
    }

    void Update()
    {
        timeSinceLastSpawn += Time.deltaTime;

        if(!GameController.instance.gameOver && timeSinceLastSpawn >= spawnRate) 
        {
            timeSinceLastSpawn = 0f;
            float spawnYPosition = Random.Range(columnMin, columnMax);
            columns[currentColumn].transform.position = new Vector2(spawnXPosition, spawnYPosition);

            currentColumn++;
            currentColumn %= columnPoolSize;
        }

    }
}
