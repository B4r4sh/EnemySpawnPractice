using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] public GameObject _player;

    public static Transform _target;
    public static bool _isPlayerActiv;

    private void Update()
    {
        if (_player.activeSelf)
        {
            _isPlayerActiv = true;
            _target = _player.transform;
        }
        else
        {
            _isPlayerActiv = false;
        }
    }
}
