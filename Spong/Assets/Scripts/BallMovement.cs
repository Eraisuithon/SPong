using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        bool player1Starts = Random.Range(0, 2) == 0; // returns true 50% of the time
        Launch(player1Starts);
    }

    public void Reset(bool Player1Scored)
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
        Launch(Player1Scored);
    }


    private void Launch(bool Player1Scored)
    {
        float x = Player1Scored ? -1 : 1;
        float y = Random.Range(0, 2)==0 ? -1 : 1; // returns -1 or 1 with 50% probability each

        rb.velocity = new Vector2(speed * x, speed * y);
    }
}
