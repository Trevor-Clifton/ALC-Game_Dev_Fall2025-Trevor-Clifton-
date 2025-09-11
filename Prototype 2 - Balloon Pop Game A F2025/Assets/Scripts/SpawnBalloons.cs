using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    [SerializeField]
    private GameObject[] balloons;
    float spawnTimer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnTimer = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTimer > 0)
        {
            spawnTimer -= 1 * Time.deltaTime;
        }
        else
        {
            Instantiate(balloons[Random.Range(0, 4)], new Vector3(Random.Range(-5f, 5f), -3, -3), Quaternion.identity);
            spawnTimer = 1f;
        }
    }
}
