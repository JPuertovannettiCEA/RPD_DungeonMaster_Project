using UnityEngine;
using UnityEngine.UI;

public class EndCondition : MonoBehaviour
{
    [SerializeField]
    private PlayerController _playerRef;

    [SerializeField]
    private EnemyAI _enemyRef;

    [SerializeField]
    private GameObject _treasureChest;

    [SerializeField]
    private Transform _treasurePosition;

    [SerializeField]
    private AudioSource _chestAppears;

    [SerializeField]
    private AudioSource _gotKey;

    private GameObject _chestRef, _infoText;

    private void Awake()
    {
        _chestRef = GameObject.FindGameObjectWithTag("ChestBar");
        _infoText = GameObject.FindGameObjectWithTag("InfoText");
        Globals._infoText = _infoText.GetComponent<TMPro.TMP_Text>();
        Globals._chestBar = _chestRef.GetComponent<Slider>();
        Globals._chestBar.value = 0f;
        Globals._chestBar.maxValue = Globals.AICount;
        Globals.DeadAI = 0;

    }

    private void FixedUpdate()
    {
        Globals._chestBar.value = Globals.DeadAI;
        // Debug.Log();
        if (Globals.AICount == Globals.DeadAI)
        {
            Instantiate(_treasureChest, _treasurePosition.transform.position, Quaternion.identity);
            Globals.DeadAI = 6.1f;
            Globals._infoText.text = ("CHEST APPEARED");
            //_chestAppears.Play();
        }
        if (Globals.KeyCollected == true)
        {
            _gotKey.Play();
            Globals._infoText.text = ("KEY COLLECTED");
        }
    }
}
