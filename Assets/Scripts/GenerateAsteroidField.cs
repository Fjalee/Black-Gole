using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateAsteroidField : MonoBehaviour
{

    public Transform asteroidPrefab;
    public int fieldRadius = 100;
    public int asteroidCount = 100;
    public float scaleFromMultiplier = 0.5f;
    public float scaleToMultiplier = 5;

    void Start()
    {

        for (int i = 0; i < asteroidCount; i++)
        {
            Transform temp = Instantiate(asteroidPrefab, this.transform.position + Random.insideUnitSphere * fieldRadius, Random.rotation, this.transform); 
            temp.localScale = temp.localScale * Random.Range(scaleFromMultiplier, scaleToMultiplier);
        }

    }

    void Update()
    {

    }
}
