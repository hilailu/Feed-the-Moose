using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    [SerializeField] private int hunger;
    [SerializeField] private Slider slider;
    
    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Player":
                PlayerStats.UpdateLives();
                break;
            case "Food":
                hunger++;
                slider.value = hunger;
                if (hunger >= slider.maxValue)
                {
                    PlayerStats.UpdateScore();
                }
                else
                {
                    return;
                }
                break;
            case "Animal":
                return;
        }
        Destroy(gameObject);
    }
}
