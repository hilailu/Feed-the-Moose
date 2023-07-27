using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] animals;
    [SerializeField] private float range = 15f;
    void Start()
    {
        StartCoroutine(SpawnAnimal());
    }

    private IEnumerator SpawnAnimal()
    {
        while (true)
        {
            var animal = animals[Random.Range(0, animals.Length)];
            var side = Random.Range(0, 4);
            Vector3 position;
            switch (side)
            {
                case 0:
                    // top
                    position = new Vector3(Random.Range(-range, range + 1), transform.position.y, transform.position.z);
                    Instantiate(animal, position, animal.transform.rotation);
                    break;
                case 1: 
                    // left
                    position = new Vector3(-range - 5, transform.position.y, Random.Range(0, range + 1));
                    Instantiate(animal, position, Quaternion.Euler(0, 90, 0));
                    break;
                case 2:
                    // right
                    position = new Vector3(range + 5, transform.position.y, Random.Range(0, range + 1));
                    Instantiate(animal, position, Quaternion.Euler(0, 270, 0));
                    break;
            }
            yield return new WaitForSeconds(0.3f);
        }
    }
}
