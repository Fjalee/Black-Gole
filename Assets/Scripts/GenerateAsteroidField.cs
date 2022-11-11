using UnityEngine;

public class GenerateAsteroidField : MonoBehaviour
{
    [SerializeField]
    private Transform _asteroidPrefab;

    [SerializeField]
    private int _fieldRadius = 100;

    [SerializeField]
    private int _asteroidCount = 100;

    [SerializeField]
    private float _scaleFromMultiplier = 0.5f;

    [SerializeField]
    private float _scaleToMultiplier = 5;

    [SerializeField]
    private float _yAxisDivider = 3f;

    [SerializeField]
    private int _seedForRandom = 42;

    void Start()
    {
        Random.InitState(_seedForRandom);
        for (int i = 0; i < _asteroidCount; i++)
        {
            var randomPosition = Random.insideUnitSphere;
            randomPosition.y /= _yAxisDivider;

            var temp = Instantiate(_asteroidPrefab, transform.position + randomPosition * _fieldRadius, Random.rotation, transform); 
            temp.localScale = Vector3.one * Random.Range(_scaleFromMultiplier, _scaleToMultiplier);
        }

    }
}
