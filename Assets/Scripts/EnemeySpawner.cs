using UnityEngine;

public class EnemeySpawner : MonoBehaviour
{
    [SerializeField]
    public Vector2 RandomPosition, MinPostion, MaxPostion;

    [SerializeField]
    public int RandomNoOfEnemies, MinEnemies, MaxEnemies;


    [SerializeField]
    private EnemyAI _enemyAIRef;

    [SerializeField]
    private GameObject _EndChecker;

    [SerializeField]
    private GameObject _enemyPrefab;

    private int enemySpawnedMax;

    private void Awake()
    {
        Instantiate(_EndChecker, transform.position, Quaternion.identity);
        RandomNoOfEnemies = Random.Range(MinEnemies,MaxEnemies);
        Globals.AICount= RandomNoOfEnemies;

    }
    private void Update()
    {
        if (enemySpawnedMax < RandomNoOfEnemies)
        {
            RandomPosition.x = Random.Range(MinPostion.x, MaxPostion.x);
            RandomPosition.y = Random.Range(MinPostion.y, MaxPostion.y);

            Instantiate(_enemyPrefab, RandomPosition, Quaternion.identity);
            enemySpawnedMax++;
        }



    }
}
