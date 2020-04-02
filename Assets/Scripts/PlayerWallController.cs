using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallController : MonoBehaviour
{
    public bool isPlayer1;

    // called when the cube hits the floor
    void OnCollisionEnter2D(Collision2D col)
    {
        if (isPlayer1)
            ScoreKeeper.OnPlayer2Score();
        else
            ScoreKeeper.OnPlayer1Score();

    }
}
