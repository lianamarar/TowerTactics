using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameOver : MonoBehaviour
{
    private bool endGame;
    private bool ignoreCollision;
    private bool ignoreTrigger;
    Rigidbody2D rb;
    public void EndTheGame() {

        
        endGame = true;
        ignoreTrigger = true;

        Invoke("RestartGame", 2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Application.Quit();
        // SceneManager.LoadScene("Game Over");
    }
}
