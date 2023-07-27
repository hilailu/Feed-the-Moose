using System.Collections;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private int minRange = 3;
    private int maxRange = 6;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRandomBall());
    }

    // Spawn random ball at random x position at top of play area
    IEnumerator SpawnRandomBall()
    {
        while (true)
        {
            // Generate random ball index and random spawn position
            Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
            // instantiate ball at random spawn location
            Instantiate(ballPrefabs[Random.Range(0, ballPrefabs.Length)], spawnPos, ballPrefabs[0].transform.rotation);
            yield return new WaitForSeconds(Random.Range(minRange, maxRange));
        }
    }

}
