using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    private GameObject[] _popUps;
    private List<GameObject> activatedGOs;
    private Camera _cameraObserve;
    private GameObject _star;
    private GameObject _blackHole;
    private GameObject _mapButton;
    private GameObject _restartButton;
    private GameObject _controlPoint;
    private int _popUpIndex = 0;
    private Rigidbody _planetBallRb;
    private int _sceneLoadCounter = 0;
    private Vector3 _tempVelocity;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;

        activatedGOs = new List<GameObject>();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        _sceneLoadCounter++;
        if (_sceneLoadCounter > 1)
        {
            setupRefs();
            activateGOs();
        }
    }

    void setupRefs()
    {
        _planetBallRb = GameObject.Find("PlanetBall").GetComponent<Rigidbody>();
        _controlPoint = GameObject.Find("Control point");

        _cameraObserve = GameObject.Find("CameraObserveLevel").GetComponent<Camera>();

        _star = GameObject.Find("Star");
        _star.SetActive(false);
        _blackHole = GameObject.Find("BlackHole");
        _blackHole.SetActive(false);
        _mapButton = GameObject.Find("Observe level");
        _mapButton.SetActive(false);
        _restartButton = GameObject.Find("Restart Button");
        _restartButton.SetActive(false);

        GameObject popUpCanvas = GameObject.Find("PopUpCanvas");
        List<GameObject> popUps = new List<GameObject>();
        foreach (Transform popUp in popUpCanvas.transform)
        {
            popUps.Add(popUp.gameObject);
        }
        _popUps = popUps.ToArray();
    }

    void activateGOs()
    {
        foreach (GameObject go in activatedGOs)
        {
            //doesn't work, because you're trying to access objects that were destroyed when reloading scene
            go.SetActive(true);
        }
    }

    void Update()
    {
        for (int i = 0; i < _popUps.Length; i++)
        {
            if (i == _popUpIndex)
            {
                Debug.Log("true");
                _popUps[i].SetActive(true);
            }
            else
            {
                _popUps[i].SetActive(false);
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
            _restartButton.SetActive(true);
            activatedGOs.Add(_restartButton);

            if (_sceneLoadCounter > 2)
                _popUpIndex++;
        }
        else if (_popUpIndex == 3)
        {
            //activate star
            _star.SetActive(true);
            activatedGOs.Add(_star);

            if (_planetBallRb.velocity != _tempVelocity)
                _popUpIndex++;

            _tempVelocity = _planetBallRb.velocity;
        }
        else if (_popUpIndex == 4)
        {
            //affected by gravity popup
            if (_sceneLoadCounter > 3)
                _popUpIndex++;
        }
        else if (_popUpIndex == 5)
        {
            //activate map button
            _mapButton.SetActive(true);
            activatedGOs.Add(_mapButton);

            if (_cameraObserve.enabled)
                _popUpIndex++;
        }
        else if (_popUpIndex == 6)
        {
            if (!_cameraObserve.enabled)
                _popUpIndex++;
        }
        else if (_popUpIndex == 7)
        {
            //activate black hole
            _blackHole.SetActive(true);
        }
    }
}
