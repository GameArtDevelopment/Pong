using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    private int _player1Score = 0;
    private int _player2Score = 0;

    public GameObject Player1ScoreText;
    public GameObject Player2ScoreText;

    public int ScoreToWin;

    private void Update()
    {
        if (_player1Score >= ScoreToWin || _player2Score >= ScoreToWin)
        {
            Debug.Log("Game Won");
            SceneManager.LoadScene("Game Over");
        }
    }

    private void FixedUpdate()
    {
        TextMeshProUGUI Player1ScoreUI = Player1ScoreText.GetComponent<TextMeshProUGUI>();
        Player1ScoreUI.text = _player1Score.ToString();

        TextMeshProUGUI Player2ScoreUI = Player2ScoreText.GetComponent<TextMeshProUGUI>();
        Player2ScoreUI.text = _player2Score.ToString();
    }

    public void Player1Score()
    {
        _player1Score++;
    }

    public void Player2Score()
    {
        _player2Score++;
    }
}
