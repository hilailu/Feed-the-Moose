using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    private float bound = 40f;
    
    void Update()
    {
        if (transform.position.z < -bound || transform.position.z > bound || transform.position.x < -bound || transform.position.x > bound)
        {
            if (gameObject.CompareTag("Animal"))
            {
                PlayerStats.UpdateLives();
            }
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
