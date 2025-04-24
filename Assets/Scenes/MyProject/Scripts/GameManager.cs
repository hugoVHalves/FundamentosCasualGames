using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject platformPrefab;
    public int platformCount = 100;
    

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < platformCount; i++)
        {
            spawnPosition.y += Random.Range(1f, 3f);
            spawnPosition.x = Random.Range(-5f, -3f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            spawnPosition.x = Random.Range(-1f, 1f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            spawnPosition.x = Random.Range(3f, 5f);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}