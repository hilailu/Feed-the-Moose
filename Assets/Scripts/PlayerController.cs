using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private GameObject projectilePrefab;
    private float horizontalInput;
    private float verticalInput;
    private const float range = 15f;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }

        switch (transform.position.x)
        {
            case < -range: 
                transform.position = new Vector3(-range, transform.position.y, transform.position.z);
                break;
            case > range:
                transform.position = new Vector3(range, transform.position.y, transform.position.z);
                break;
        }

        switch (transform.position.z)
        {
            case < 0:
                transform.position = new Vector3(transform.position.x, transform.position.y, 0);
                break;
            case > range:
                transform.position = new Vector3(transform.position.x, transform.position.y, range);
                break;
        }
        
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
    }
}
