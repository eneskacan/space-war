using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour
{
    [SerializeField]
    GameObject gameName;

    [SerializeField]
    GameObject gameOver;

    [SerializeField]
    Text score;

    [SerializeField]
    GameObject playButton;

    int playerScore;

    // Start is called before the first frame update
    void Start()
    {
        gameOver.gameObject.SetActive(false);
        score.gameObject.SetActive(false);
    }

    public void GameStarted()
    {
        gameName.gameObject.SetActive(false);
        score.gameObject.SetActive(true);
        playButton.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        playerScore = 0;
        UpdateScore();
    }

    public void GameOver()
    {
        gameOver.gameObject.SetActive(true);
        playButton.gameObject.SetActive(true);
    }

    void UpdateScore()
    {
        score.text = "SCORE: " + playerScore;
    }

    public void IncreaseScore(GameObject asteroid)
    {
        switch(asteroid.gameObject.name[8])
        {
            case '1':
                playerScore += 100;
                break;
            case '2':
                playerScore += 200;
                break;
            case '3':
                playerScore += 300;
                break;
        }

        UpdateScore();
    }
}
