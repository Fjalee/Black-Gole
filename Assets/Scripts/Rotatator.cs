using UnityEngine;

public class Rotatator : MonoBehaviour {
	[SerializeField] 
	private Vector3 _rotation;

	[SerializeField] 
	private Transform _meshObject = null;

	[SerializeField] 
	private float _rotationSpeed = 0;

	[SerializeField] 
	private bool _randomize;

	[SerializeField]
	private float _maxSpeed;

	[SerializeField]
	private float _minSpeed;

	public bool Randomize 
	{
		get
		{
			return _randomize;
		}
	}

	// Use this for initialization
	void Start ()
	{
		if (_randomize)
		{
			_rotation = new Vector3(RandFloat(), RandFloat(), RandFloat());
			_rotationSpeed = Random.Range(_minSpeed, _maxSpeed);
		}
	}
	
	float RandFloat() 
	{
		return Random.Range(0f, 1.01f);
	}
	
	// Update is called once per frame
	void FixedUpdate() 
	{
        if(_meshObject != null)
        {
			_meshObject.Rotate(_rotation, _rotationSpeed * Time.deltaTime);
		}
	}
}
