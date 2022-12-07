using System;
using System.Collections.Generic;
using Helpers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Inputs
{
    public class RememberLastTrajectory : MonoBehaviour
    {
        [SerializeField] 
        private LineRenderer _trajectoryLine;

        [SerializeField]
        private ControlPoint _controlPoint;

        [SerializeField]
        private Rigidbody _planet;

        [NonSerialized]
        public bool LevelCompleted = false; 

        private List<Vector3> _trajectoryPositions = new();

        private void Start()
        {
            if (_trajectoryLine)
            {
                LoadTrajectoryFromPlayerPrefs();
            }
        }

        private void Update()
        {
            if (_trajectoryLine && _controlPoint && _controlPoint.IsPlanetLaunched)
            {
                _trajectoryPositions.Add(_planet.position);
            }
        }

        private void OnDestroy()
        {
            if (!_trajectoryLine)
            {
                return;
            }

            if (LevelCompleted)
            {
                RemoveCurrentLevelTrajectory();
            }
            else
            {
                SaveTrajectoryToPlayerPrefs();
            }
        }

        private void SaveTrajectoryToPlayerPrefs()
        {
            if (!_controlPoint.IsPlanetLaunched && LevelCompleted)
            {
                return;
            }

            var json = JsonUtility.ToJson(new JsonListWrapper<Vector3>(_trajectoryPositions));

            PlayerPrefs.SetString($"trajectory_{SceneManager.GetActiveScene().name}", json);
        }

        private void LoadTrajectoryFromPlayerPrefs()
        {
            var json = PlayerPrefs.GetString($"trajectory_{SceneManager.GetActiveScene().name}");

            if (string.IsNullOrEmpty(json))
            {
                return;
            }

            var trajectoryPositions = JsonUtility.FromJson<JsonListWrapper<Vector3>>(json).list;

            _trajectoryLine.positionCount = trajectoryPositions.Count;
            _trajectoryLine.SetPositions(trajectoryPositions.ToArray());
            _trajectoryLine.gameObject.SetActive(true);
        }

        private void RemoveCurrentLevelTrajectory()
        {
            PlayerPrefs.DeleteKey($"trajectory_{SceneManager.GetActiveScene().name}");
        }
    }
}
