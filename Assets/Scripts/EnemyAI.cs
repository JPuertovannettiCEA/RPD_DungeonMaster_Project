using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _enemyRB;

    private GameObject _player;

    [SerializeField]
    public float Health = 100f;

    [SerializeField]
    public int _EnemyNumber;

    [SerializeField]
    public bool _isDead;

    [SerializeField]
    private Vector2 _movement;

    [SerializeField]
    private float _moveSpeed = 0.5f;

    [SerializeField]
    private float _attackValue;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        HealthCondition();
    }

    private void HealthCondition()
    {
        if (Health <= 0)
        {
            _isDead = true;
            this.gameObject.SetActive(false);
            Globals.DeadAI++;
            Debug.Log(Globals.DeadAI);

        }
    }

    private void RotateCharacter()
    {
        Vector3 direction = _player.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _enemyRB.rotation = angle;
        direction.Normalize();
        _movement = direction;
    }

    private void moveCharacter(Vector2 direction) => _enemyRB.MovePosition((Vector2)transform.position + (direction * _moveSpeed * Time.deltaTime));

    private void FixedUpdate()
    {
        moveCharacter(_movement);
        RotateCharacter();
    }

}
