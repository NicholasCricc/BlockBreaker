using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Paddle myPaddle;

    //array of Sounds declaration
    [SerializeField] AudioClip[] ballSounds;

    Vector2 paddleToBallDistance;

    bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        paddleToBallDistance = this.transform.position - myPaddle.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted) // (hasStarted == false)
        {
            LockBallToPaddle();
            LaunchBallOnMouseClick();
        }
        
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        //generate random number
        int randomNumber = UnityEngine.Random.Range(0, ballSounds.Length);

        AudioClip clip = ballSounds[randomNumber];

        GetComponent<AudioSource>().PlayOneShot(clip);
    }

    private void LaunchBallOnMouseClick()
    {
        
        if (Input.GetMouseButtonDown(0)) //left click
        {
            hasStarted = true;
            //shoot the ball
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 15f);
        }
    }

    private void LockBallToPaddle()
    {
        //get the position of the paddle
        Vector2 paddlePosition = myPaddle.transform.position;
        //set the position of the Ball to the paddle Position + distance
        this.transform.position = paddlePosition + paddleToBallDistance;
    }
}
