using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    private GameObject[] _popUps;
    private List<string> _activatedGOs;
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

        _activatedGOs = new List<string>();
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "LevelSelectorWindow")
        {
            Destroy(transform.gameObject);
        }
        else
        {
            _sceneLoadCounter++;
            if (_sceneLoadCounter > 1)
            {
                setupRefs();
                activateGOs();
            }
        }
    }

    void setupRefs()
    {
        _planetBallRb = GameObject.Find("PlanetBall").GetComponent<Rigidbody>();
        _controlPoint = GameObject.Find("Control point");

        _cameraObserve = GameObject.Find("CameraObserveLevel").GetComponent<Camera>();

        _star = GameObject.Find("Star");
        _star.SetActive(_activatedGOs.Contains("Star"));
        _blackHole = GameObject.Find("BlackHole");
        _blackHole.SetActive(_activatedGOs.Contains("BlackHole"));
        _mapButton = GameObject.Find("Observe level");
        _mapButton.SetActive(_activatedGOs.Contains("Observe level"));
        _restartButton = GameObject.Find("Restart Button");
        _restartButton.SetActive(_activatedGOs.Contains("Restart Button"));

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
        // foreach (GameObject go in _activatedGOs)
        // {
        //     //doesn't work, because you're trying to access objects that were destroyed when reloading scene
        //     go.SetActive(true);
        // }
    }

    void Update()
    {
        for (int i = 0; i < _popUps.Length; i++)
        {
            if (i == _popUpIndex)
            {
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
            //activate restart button and ask to restart level
            _restartButton.SetActive(true);
            _activatedGOs.Add("Restart Button");

            if (_sceneLoadCounter > 2)
                _popUpIndex++;
        }
        else if (_popUpIndex == 3)
        {
            //activate star and ask to launch ball
            _star.SetActive(true);
            _activatedGOs.Add("Star");

            if (_planetBallRb.velocity != _tempVelocity)
                _popUpIndex++;

            _tempVelocity = _planetBallRb.velocity;
        }
        else if (_popUpIndex == 4)
        {
            //affected by gravity popup explanation
            if (_sceneLoadCounter > 3)
                _popUpIndex++;
        }
        else if (_popUpIndex == 5)
        {
            //activate map button and ask to press it
            _mapButton.SetActive(true);
            _activatedGOs.Add("Observe level");

            if (_cameraObserve.enabled)
                _popUpIndex++;
        }
        else if (_popUpIndex == 6)
        {
            //activate black hole and ask to come back to level
            _blackHole.SetActive(true);
            _activatedGOs.Add("BlackHole");
            if (!_cameraObserve.enabled)
                _popUpIndex++;
        }
        else if (_popUpIndex == 7)
        {
            //prompt to get the PlanetBall into the BlackHole to finish tutorial
        }
    }
}
