using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class TreasueChest : MonoBehaviour
{
    [SerializeField]
    private GameObject _KeyAppeared;
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Keyboard.current.eKey.isPressed)
            {
                Instantiate(_KeyAppeared, transform.position, Quaternion.identity);
                gameObject.SetActive(false);
                Globals.KeyCollected = true;

            }
        }
    }
}
