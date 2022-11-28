using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    [SerializeField] private bool isPlayer1;
    [SerializeField] private float speed;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] public Vector3 startPosition;

    private List<int> any_direction_easter_egg = new List<int>(){1, -1, -1, 1, -1, 1, 1, -1};
    private int index_adee = 0;
    private bool not_moving = false; // when player wasn't moving


    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float movement_x = 0;
        float movement_y = 0;
        if (isPlayer1)
        {
            movement_y = Input.GetAxisRaw("Vertical") * speed;
            movement_x = Input.GetAxisRaw("Horizontal") * speed / 2;
        }
        else
        {
            movement_y = Input.GetAxisRaw("Vertical 2") * speed;
            movement_x = Input.GetAxisRaw("Horizontal 2") * speed / 2;
        }
        int list_size = any_direction_easter_egg.Count;
        if (movement_y == 0)
            not_moving = true;
        else if (index_adee < list_size && any_direction_easter_egg[index_adee] * movement_y > 0 && not_moving) // the multiplication is positive if both go at the same direction
        {
            index_adee++;
            not_moving = false;
            Debug.Log(index_adee);
        }
        else if (index_adee < list_size && any_direction_easter_egg[index_adee] * movement_y < 0 && not_moving)
        {
            Debug.Log("-------------");
            Debug.Log(index_adee);
            index_adee = 0;
        }
        else if (index_adee == list_size)
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;

        rb.velocity = new Vector2(movement_x, movement_y);
    }

    public void Reset()
    {
        index_adee = 0;
        GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation | RigidbodyConstraints2D.FreezePositionX;
        transform.position = startPosition;
    }
}
