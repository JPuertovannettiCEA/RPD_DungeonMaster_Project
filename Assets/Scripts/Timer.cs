using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private TMP_Text _textRef;
    [SerializeField]
    private float StartTimer = 60f;

    private void Awake()
    {
        _textRef.text = "60";
    }

    private void Update()
    {
        StartTimer -= Time.deltaTime;
        float seconds = Mathf.FloorToInt(StartTimer);
        _textRef.text = string.Format("{00}", seconds);

        if(StartTimer<20f)
        {
            _textRef.color = Color.red;
        }

        if(StartTimer<=1)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
