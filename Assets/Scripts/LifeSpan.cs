using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSpan : MonoBehaviour
{
    [SerializeField]
    private float _lifeSpan;

    private void Awake()
    {
        Destroy(gameObject,_lifeSpan);
    }
}
