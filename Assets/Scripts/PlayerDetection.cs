using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    public static Transform _target;
    public static bool _isPlayerActiv;

    private void Awake()
    {
        _isPlayerActiv = true;
    }
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
