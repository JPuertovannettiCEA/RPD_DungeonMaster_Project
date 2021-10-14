using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;

public class TreasueChest : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Keyboard.current.eKey.isPressed)
            {
                gameObject.SetActive(false);
                Globals.KeyCollected = true;
            }
        }
    }
}
