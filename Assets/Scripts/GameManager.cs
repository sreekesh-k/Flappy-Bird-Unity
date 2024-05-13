using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score;

    public void GameOver()
    {
        Debug.Log("GAME OVER");
    }
    public void IncreaseScore()
    {
        score++;
    }
}
