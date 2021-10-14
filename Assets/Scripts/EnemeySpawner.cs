using UnityEngine;

public class EnemeySpawner : MonoBehaviour
{
    [SerializeField]
    public Vector2 RandomPosition, MinPostion, MaxPostion;


    [SerializeField]
    private EnemyAI _enemyAIRef;

    [SerializeField]
    private GameObject _EndChecker;

    [SerializeField]
    private GameObject _enemyPrefab;

    [SerializeField]
    private Transform _enemy1sp, _enemy2sp, _enemy3sp, _enemy4sp, _enemy5sp, _enemy6sp;

    private void Awake()
    {
        Instantiate(_EndChecker, transform.position, Quaternion.identity);
        Globals.AICount = 6;
        Instantiate(_enemyPrefab, _enemy1sp.transform.position, Quaternion.identity);
        Instantiate(_enemyPrefab, _enemy2sp.transform.position, Quaternion.identity);
        Instantiate(_enemyPrefab, _enemy3sp.transform.position, Quaternion.identity);
        Instantiate(_enemyPrefab, _enemy4sp.transform.position, Quaternion.identity);
        Instantiate(_enemyPrefab, _enemy5sp.transform.position, Quaternion.identity);
        Instantiate(_enemyPrefab, _enemy6sp.transform.position, Quaternion.identity);

    }
}
