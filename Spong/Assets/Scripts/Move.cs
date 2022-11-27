using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] private bool isPlayer1;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] public Vector3 startPosition;


    private float movement = 0;

    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer1)
            movement = Input.GetAxisRaw("Vertical");
        else
            movement = Input.GetAxisRaw("Vertical 2");

        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }
}
