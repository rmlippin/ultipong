using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    // Public variables
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Awake()
    {
        print("Awake");
        Debug.Log("Awake");
    }

    public void OnMove(InputValue value)
    {
        Vector2 input = value.Get<Vector2>();
        input.x = 0.0f; //Remove x movement

        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = input * speed;
    }
}
