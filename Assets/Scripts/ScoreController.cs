using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreController : MonoBehaviour
{
    public Text score;
    private int scoreValue;
    private bool endGame;
    private bool ignoreCollision;
    private bool ignoreTrigger;
    Rigidbody2D rb;
    GameOver gameOverScript;
    GoodFoodController goodFoodScript;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gameOverScript = GameObject.Find("GameManager").GetComponent<GameOver>();
        goodFoodScript = GameObject.Find("GameManager").GetComponent<GoodFoodController>();
    }


    void Update()
    {   
        score.text = scoreValue.ToString();
    }
    void Found()
    {
        if (endGame)
        {
            return;
        }

        ignoreCollision = true;
        ignoreTrigger = true;
        //UI_Manager.instance.MoveCamera;    
    }
    void RestartGame()
    {
        UI_Manager.instance.RestartGame();
    }

    void OnCollisionEnter2D(Collision2D target)
    {
        if (ignoreCollision)
        {
            return;
        }
        if (target.gameObject.tag == "Platform")
        {
            Invoke("Found", 1f);
            ignoreCollision = true;
            scoreValue++;
        }
        if (target.gameObject.tag == "goodfood")
        {
            Invoke("Found", 1f);
            ignoreCollision = true;
            scoreValue++;       
        }
    }
    void OnTriggerEnter2D(Collider2D target)
    {

        if (ignoreTrigger)
        {
            return;
        }
        if (target.tag == "badfood")
        {

            CancelInvoke("Platform");
            CancelInvoke("goodfood");
            gameOverScript.EndTheGame();

        }
    }
 
}
