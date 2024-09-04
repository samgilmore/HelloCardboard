using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    public TMP_Text timerText;
    public float gameTime = 60f;

    void Update()
    {
        gameTime -= Time.deltaTime;
        int timeRemaining = Mathf.CeilToInt(gameTime);
        timerText.SetText("Time: " + timeRemaining.ToString());

        if (timeRemaining <= 0)
        {
            EndGame();
        }
    }

    void EndGame()
    {
        timerText.SetText("Game Over!");
    }
}