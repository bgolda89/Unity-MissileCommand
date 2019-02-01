using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GM : MonoBehaviour {

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 cursorHotspot;

    public GameObject gameOverMenu;
    private bool gameOver;
    private bool restart;
    private int score;

    public TextMeshProUGUI scoreText;

    void Start()
    {
        gameOver = false;
        restart = false;
        score = 0;
        UpdateScore();
        cursorHotspot = new Vector2(cursorTexture.width / 2, cursorTexture.height / 2);
        Cursor.SetCursor (cursorTexture, cursorHotspot, cursorMode);
    }

	// Update is called once per frame
	void Update () {
        if (PlayerStats.currentHealth <= 0){
            GameOver();
        }
	}

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0;
        gameOver = true;
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }
}
