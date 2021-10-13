using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private RPD_DungeonMaster_Project _playerInput;

    private Rigidbody2D _playerRb;

    [SerializeField]
    private float _speed = 10f;

    [SerializeField]
    private EnemyAI _enemyRef;

    private void Awake()
    {
        _playerInput = new RPD_DungeonMaster_Project();
        _playerRb = GetComponent<Rigidbody2D>();
        Globals.PlayerHealth = 100f;
    }

    private void OnEnable()
    {
        _playerInput.Enable();
    }

    private void OnDisable()
    {
        _playerInput.Disable();
    }

    private void FixedUpdate()
    {
        Vector2 moveInput = _playerInput.Player.Move.ReadValue<Vector2>();
        _playerRb.velocity = moveInput * _speed;

        // Globals.hittingEnemy = Mouse.current.leftButton.isPressed;

        if (Globals.hittingEnemy = Mouse.current.leftButton.isPressed)
        {   
        }
    }


}
