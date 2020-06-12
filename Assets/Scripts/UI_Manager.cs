using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public static UI_Manager instance;

    public CameraFollow cameraScript;
    private int moveCount;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void RestartGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(
            UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
    public void MoveCamera()
    {
        moveCount++;
        if(moveCount == 15)
        {
            moveCount = 0;
            //cameraScript.targetPos.y += 1f;
        }
    }
}
