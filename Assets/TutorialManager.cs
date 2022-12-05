using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private GameObject _levelUI;
    private GameObject _planetBall;
    public GameObject star;
    public GameObject blackHole;
    public GameObject mapButton;
    public GameObject restartButton;
    private GameObject _controlPoint;
    private int _popUpIndex;
    private Rigidbody _planetBallRb;
    private int _sceneLoadCounter = 0;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        _sceneLoadCounter++;
    }

    void Start()
    {
        _planetBall = GameObject.Find("PlanetBall");
        _controlPoint = GameObject.Find("Control point");
        _levelUI = GameObject.Find("LevelUI");
        _planetBallRb = _planetBall.GetComponent<Rigidbody>();

        DontDestroyOnLoad(star);
        DontDestroyOnLoad(blackHole);
        DontDestroyOnLoad(_levelUI);
    }

    void Update()
    {
        for (int i = 0; i < popUps.Length; i++)
        {
            if (i == _popUpIndex)
            {
                popUps[_popUpIndex].SetActive(true);
            }
            else
            {
                popUps[_popUpIndex].SetActive(false);
            }
        }

        if (_popUpIndex == 0)
        {
            //activate only planetball, nothing else, prompt with panning
            if (_controlPoint.transform.eulerAngles != Vector3.zero)
                _popUpIndex++;
        }
        else if (_popUpIndex == 1)
        {
            //prompt with holding down and releasing planetBall, cancelling launch
            if (_planetBallRb.velocity != Vector3.zero)
                _popUpIndex++;
        }
        else if (_popUpIndex == 2)
        {
            //activate restart button
            restartButton.SetActive(true);
            if (_sceneLoadCounter > 1)
                _popUpIndex++;
        }
        else if (_popUpIndex == 3)
        {
            //activate star
            star.SetActive(true);
            //if affected by gravity and out of gravity field or burn up
            _popUpIndex++;
        }
        else if (_popUpIndex == 4)
        {
            //activate map button
            mapButton.SetActive(true);
            //if map button pressed
            _popUpIndex++;
        }
        else if (_popUpIndex == 5)
        {
            //activate black hole
            blackHole.SetActive(true);
            //if map button pressed
            _popUpIndex++;
        }

    }
}
