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
        print(value.ToString());
        Debug.Log(value.ToString());
       // Rigidbody2D rb2D = GetComponent<Rigidbody2D>();
       //rb2D.velocity = new Vector2(0, userInputVert) * speed;
    }
}
