using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeeper : MonoBehaviour
{

    private static int player1Score;
    private static int player2Score;
    private static TextMeshProUGUI text;

    void Start()
    {
        text = gameObject.GetComponent<TextMeshProUGUI>();
    }

    public static void OnPlayer1Score()
    {
        player1Score++;
        Rewrite();
    }

    public static void OnPlayer2Score()
    {
        player2Score++;
        Rewrite();
    }

    public static void ClearScore()
    {
        player2Score = 0;
        player1Score = 0;
        Rewrite();
    }

    public static void Rewrite()
    {
        text.text = player1Score + " - " + player2Score;
    }

}
