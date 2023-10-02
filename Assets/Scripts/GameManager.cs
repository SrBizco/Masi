using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 2f;
    public float minSpawnDistance = 5f; 

    private float tiempoUltimoSpawn = 0f;
    private Transform jugador;

    void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        
        if (Time.time > tiempoUltimoSpawn + spawnRate)
        {
            if (Vector2.Distance(jugador.position, transform.position) > minSpawnDistance)
            {
                SpawnEnemy();
                tiempoUltimoSpawn = Time.time;
            }
        }
    }

    void SpawnEnemy()
    {
        float distanceToPlayer = Vector2.Distance(jugador.position, transform.position);
        Debug.Log("Distancia al jugador: " + distanceToPlayer);

        if (distanceToPlayer > minSpawnDistance)
        {
            
            Vector2 randomPosition = new Vector2(Random.Range(-10f, 10f), Random.Range(-5f, 5f));
            GameObject newEnemy = Instantiate(enemyPrefab, new Vector3(randomPosition.x, randomPosition.y, 0f), Quaternion.identity);
        }
    }

}

