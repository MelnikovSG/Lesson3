﻿using UnityEngine;

namespace RollBall 
{ 
    public class GameController : MonoBehaviour
    {
        private InteractiveObject[] _interactiveObjects;
        private void Awake()
        {
            _interactiveObjects = FindObjectsOfType<InteractiveObject>();
        }


        private void Update()
        {
            for (var i = 0; i < _interactiveObjects.Length; i++)
            {
                var interactiveObject = _interactiveObjects[i];
                if (interactiveObject == null)
                {
                    continue;
                }
            }
        }

    }
}

