using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D _enemyRB;

    private RPD_DungeonMaster_Project _playerInput;

    private GameObject _player;

    [SerializeField]
    public int _EnemyNumber;

    [SerializeField]
    public bool _isDead;

    [SerializeField]
    private Vector2 _movement;

    [SerializeField]
    private float _moveSpeed = 0.5f;

    [SerializeField]
    public float EnemyHealth;

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        EnemyHealth = 100f;
    }
    private void Update()
    {
        HealthCondition();
    }

    private void HealthCondition()
    {
        if (EnemyHealth <= 0)
        {
            _isDead = true;
            this.gameObject.SetActive(false);
            Globals.DeadAI++;
            Debug.Log(Globals.DeadAI);

        }
    }

    private void RotateCharacter()
    {
        Vector3 direction = (_player.transform.position + new Vector3(0.2f, 0.2f, 0f)) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        _enemyRB.rotation = angle;
        direction.Normalize();
        _movement = direction;
    }

    private void moveCharacter(Vector2 direction) => _enemyRB.MovePosition((Vector2)transform.position + (direction * _moveSpeed * Time.deltaTime));

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Debug.Log($"entertag");
            moveCharacter(_movement);
            RotateCharacter();
            if (Globals.hittingEnemy)
            {
                Debug.Log(Globals.hittingEnemy);
                EnemyHealth -= Globals.AIAttackValue;
                Debug.Log(EnemyHealth);
            }

        }
    }

    private void FixedUpdate()
    {

        // _playerInput.Player.Fire.started += ctx => Globals.hittingEnemy = true;
    }

}
