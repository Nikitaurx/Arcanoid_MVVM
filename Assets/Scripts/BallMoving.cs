using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMoving : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody;
    [Range(1f, 2f)]
    [SerializeField] float speedBall = 1.5f;


    void Start()
    {
        rigidbody.velocity = new Vector2(Random.Range(2f, 4f), Random.Range(2f, 4f)) * speedBall;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Lose"))
        {
            Debug.Log("You lose!");
            Destroy(gameObject);
        }
    }
}
