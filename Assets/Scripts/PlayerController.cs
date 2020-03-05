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
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
        rb2D.velocity = value.Get<Vector2>() * speed;
    }
}
