using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFoodController : MonoBehaviour
{
    public int scoreValue;
    private bool endGame;
    private bool ignoreCollision;
    GameOver gameOverScript;

    void Awake()
    {
        gameOverScript = GameObject.Find("GameManager").GetComponent<GameOver>();
    }
    void OnCollisionEnter2D(Collision2D target)
    {
        if (ignoreCollision)
        {
            return;
        }
        else if (target.gameObject.tag == "badfood")
        {
            CancelInvoke("Platform");
            CancelInvoke("goodfood");
            gameOverScript.EndTheGame();
        }
        else if (target.gameObject.tag == "goodfood")
        {
            scoreValue++;
        }
        else
        {
            return;
        }
    }
}
