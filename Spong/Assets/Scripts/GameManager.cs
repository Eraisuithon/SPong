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
        Ball.GetComponent<BallMovement>().Reset();
    }

    public void Player2Scored()
    {
        Player2Score++;
        Player2Text.GetComponent<TextMeshProUGUI>().text = Player2Score.ToString();
        ResetPosition();
        Ball.GetComponent<BallMovement>().Reset();
    }

    private void ResetPosition()
    {
        Player1.transform.position = Player1.GetComponent<Move>().startPosition;
        Player2.transform.position = Player2.GetComponent<Move>().startPosition;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
