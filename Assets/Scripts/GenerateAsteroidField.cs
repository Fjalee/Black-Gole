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
    public float yAxisDivider = 3f;

    void Start()
    {
        for (int i = 0; i < asteroidCount; i++)
        {
            Vector3 randomPosition = Random.insideUnitSphere;
            randomPosition.y /= yAxisDivider;

            Transform temp = Instantiate(asteroidPrefab, transform.position + randomPosition * fieldRadius, Random.rotation, transform); 
            temp.localScale = Vector3.one * Random.Range(scaleFromMultiplier, scaleToMultiplier);
        }

    }
}
