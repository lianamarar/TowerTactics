using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemSpawner : MonoBehaviour
{
    public GameObject[] goodFood;
    public GameObject badFood;

    public float xBounds;
    public float yBound;
    void Start()
    {
        StartCoroutine(SpawnRandomGameObject());
    }

    IEnumerator SpawnRandomGameObject()
    {
        yield return new WaitForSeconds(Random.Range(1, 2));
        int randomFood = Random.Range(0, goodFood.Length);

        if(Random.value <= .6f)
        {
            Instantiate(goodFood[randomFood], new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity);
        }
        else
        {
            Instantiate(badFood, new Vector2(Random.Range(-xBounds, xBounds), yBound), Quaternion.identity); 
        }
        StartCoroutine(SpawnRandomGameObject());
    }

}
