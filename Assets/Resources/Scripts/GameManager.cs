using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private int _player1Score = 0;
    private int _player2Score = 0;

    public GameObject Player1ScoreText;
    public GameObject Player2ScoreText;

    public TextMeshProUGUI Player1ScoreUI;
    public TextMeshProUGUI Player2ScoreUI;

    public int ScoreToWin;

    private void Awake()
    {
        SurfaceEffect.Score += AnimScore;

        Player1ScoreUI = GetComponent<TextMeshProUGUI>();
        Player2ScoreUI = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        if (_player1Score >= ScoreToWin || _player2Score >= ScoreToWin)
        {
            Debug.Log("Game Won");
        }
    }

    private void FixedUpdate()
    {
        Player1ScoreUI.text = _player1Score.ToString();
        Player2ScoreUI.text = _player2Score.ToString();
    }

    private IEnumerator EnlargeScore()
    {
        for (float i = 1f; i <= 1.2f; i += .05f)
        {
            Player1ScoreUI.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForEndOfFrame();
        }

        Player1ScoreUI.rectTransform.localScale = new Vector3(1.2f, 1.2f, 1.2f);

        _player1Score += 1;

        for (float i = 1.2f; i >= 1f; i -= .05f)
        {
            Player1ScoreUI.rectTransform.localScale = new Vector3(i, i, i);
            yield return new WaitForEndOfFrame();
        }

        Player1ScoreUI.rectTransform.localScale = new Vector3(1f, 1f, 1f);

    }

    public void AnimScore()
    {
        StartCoroutine(EnlargeScore());
    }
    private void OnDestroy()
    {
        SurfaceEffect.Score -= AnimScore;
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
