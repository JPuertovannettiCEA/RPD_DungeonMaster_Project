using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCondition : MonoBehaviour
{
    [SerializeField]
    private PlayerController _playerRef;

    [SerializeField]
    private EnemyAI _enemyRef;

    [SerializeField]
    private GameObject _treasureChest;

    [SerializeField]
    private Vector3 _treasureOffset;

    private void Awake()
    {
        Globals.DeadAI=0;

    }

    private void FixedUpdate()
    {
        // Debug.Log();
        if (Globals.AICount == Globals.DeadAI)
        {
            Instantiate(_treasureChest, _playerRef.transform.position + _treasureOffset, Quaternion.identity);
            // Debug.Log(_noOfDeadAI);
            Globals.DeadAI=-2;
        }
    }
}
