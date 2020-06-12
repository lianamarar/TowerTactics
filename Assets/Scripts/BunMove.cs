using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunMove : MonoBehaviour
{
    private Rigidbody2D myBody;
    public float speed;
    public float xBound;

    

 
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        if(x > 0)
        {
            myBody.velocity = Vector2.right * speed;
        }
        else if(x < 0)
        {
            myBody.velocity = Vector2.left * speed;
        }
        else
        {
            myBody.velocity = Vector2.zero;
        }

        //transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound),
        //transform.position.y);
    }

}

