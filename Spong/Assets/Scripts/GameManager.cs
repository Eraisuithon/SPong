using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("Ball")]
    [SerializeField] private GameObject Ball;

    [Header("Player1")]
    [SerializeField] private GameObject Player1;
    [SerializeField] private GameObject player1Goal;

    [Header("Player2")]
    [SerializeField] private GameObject Player2;
    [SerializeField] private GameObject player2Goal;

    [Header("Score UI")]
    [SerializeField] private GameObject Player1Text;
    [SerializeField] private GameObject Player2Text;

    private int Player1Score = 0;
    private int Player2Score = 0;

    public void Player1Scored()
    {
        Player1Score++;
        Player1Text.GetComponent<TextMeshProUGUI>().text = Player1Score.ToString();
        ResetPosition();
        Ball.GetComponent<BallMovement>().Reset(true);
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
        Ball.GetComponent<BallMovement>().Reset(false);
    }

    private void ResetPosition()
    {
        Player1.GetComponent<Move>().Reset();
        Player2.GetComponent<Move>().Reset();
    }
}
