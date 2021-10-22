using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private RPD_DungeonMaster_Project _playerInput;

    private Rigidbody2D _playerRb;

    [SerializeField]
    private float _speed = 10f;

    [SerializeField]
    private EnemyAI _enemyRef;

    [SerializeField]
    private Vector3 _enemyOffset;

    [SerializeField]
    private Vector3 _minusOffset;

    private GameObject _healthRef;
    private AudioSource _attackSFX;

    [SerializeField]
    private AudioSource _hitSFX;

    [SerializeField]
    private AudioSource _pauseIn;

    [SerializeField]
    private GameObject _playerKilledAudio;

    [SerializeField]
    private GameObject _killPlayer;

    public Animator _anim;

    private void Awake()
    {
        _healthRef = GameObject.FindGameObjectWithTag("HealthBar");
        Globals._healthBar = _healthRef.GetComponent<Slider>();
        _playerInput = new RPD_DungeonMaster_Project();
        _playerRb = GetComponent<Rigidbody2D>();
        Globals.PlayerHealth = 100f;
        Globals._healthBar.value = Globals.PlayerHealth;
        _attackSFX = GetComponent<AudioSource>();
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
        _anim.SetFloat("AnimMoveX", moveInput.x);
        _anim.SetFloat("AnimMoveY", moveInput.y);
        _anim.SetFloat("AnimMoveMagnitude", moveInput.magnitude);

        Globals.hittingEnemy = Keyboard.current.spaceKey.isPressed;
    }

    private void Update()
    {
        if (Globals.PlayerHealth <= 0)
        {
            Instantiate(_playerKilledAudio, transform.position, Quaternion.identity);
            this.gameObject.SetActive(false);
            SceneManager.LoadScene("GameOver");
        }

        if (Keyboard.current.qKey.isPressed)
        {
            _pauseIn.Play();
            Time.timeScale = 0;

        }

        if (Keyboard.current.spaceKey.isPressed)
        {
            _attackSFX.Play();

        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            _minusOffset = other.transform.position.normalized - transform.position.normalized;
            Debug.Log(_minusOffset);
            if (_minusOffset.x <= _enemyOffset.x && _minusOffset.y <= _enemyOffset.y)
            {
                Globals.PlayerHealth -= Globals.PlayerAttackValue;
                Globals._healthBar.value = Globals.PlayerHealth;
                Instantiate(_killPlayer, transform.position, Quaternion.identity);
                Debug.Log(Globals.PlayerHealth);
            }
        }
    }

    //void Animate()
    //{
    //    _anim.SetFloat("AnimMoveX", moveDire)
    //}


}
