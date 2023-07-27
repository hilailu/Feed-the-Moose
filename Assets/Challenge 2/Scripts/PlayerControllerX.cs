using System.Collections;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    [SerializeField] private GameObject dogPrefab;
    [SerializeField] private float timeRange = 1f;
    void Start()
    {
        StartCoroutine(SpawnDog());
    }

    IEnumerator SpawnDog()
    {
        while (true)
        {
            // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                yield return new WaitForSeconds(timeRange);
            }
            yield return null;
        }
    }
}
