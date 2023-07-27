using UnityEngine;

public static class PlayerStats
{
    private static int lives = 3;
    private static int score = 0;

    public static void UpdateScore()
    {
        score++;
        Debug.Log($"Score: {score}");
    }
    
    public static void UpdateLives()
    {
        lives--;
        Debug.Log(lives < 0 ? "Game over" : $"Lives: {lives}");
    }
}
