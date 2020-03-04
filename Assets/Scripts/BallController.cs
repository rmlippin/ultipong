using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // Public variables
    public float speed = 2.0f;
    public float secBeforeRound = 3.0f;

    // Private Variables
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        SetReferences();

        // Start first round
        StartCoroutine(StartRound(1, secBeforeRound));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetReferences()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    //// Places ball in center, then moves it in some direction
    //void StartRound(int roundNum)
    //{
    //    // Move ball to center
    //    gameObject.transform.position = new Vector3(0, 0, 0);

    //    StartCoroutine(WaitForSec(3));

    //    // Push it in some direction
    //    float randomInputVert = Random.Range(0.0f, 1.0f);
    //    float randomInputHori = Random.Range(0.0f, 1.0f);
    //    rb2D.velocity = new Vector2(randomInputHori, randomInputVert) * speed;
    //}


    IEnumerator StartRound(int round, float sec)
    {
        // Move ball to center
        gameObject.transform.position = new Vector3(0, 0, 0);

        yield return new WaitForSeconds(sec);

        // Push it in some direction
        float randomInputVert = Random.Range(0.0f, 1.0f);
        float randomInputHori = Random.Range(0.0f, 1.0f);
        rb2D.velocity = new Vector2(randomInputHori, randomInputVert) * speed;
    }
}
