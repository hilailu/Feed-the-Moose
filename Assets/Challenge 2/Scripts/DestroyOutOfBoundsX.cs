using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -50;
    private float bottomLimit = -10;
    
    void Update()
    {
        if (transform.position.x < leftLimit || transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
