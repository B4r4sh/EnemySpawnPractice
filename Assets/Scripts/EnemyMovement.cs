using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector2 _playerPosition;

    void Update()
    {
        if (PlayerDetection._isPlayerActiv)
        {
            _playerPosition = PlayerDetection._target.position;
            transform.position = Vector2.MoveTowards(transform.position, _playerPosition, _speed * Time.deltaTime);
        }
    }
}
