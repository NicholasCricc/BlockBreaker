using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;

    Vector2 paddlePosition;

    // Start is called before the first frame update
    void Start()
    {
        //set the paddle position to its starting position on the screen
        paddlePosition = new Vector2(transform.position.x, transform.position.y);
        
    }

    // Update is called once per frame
    void Update()
    {
        float mousePos=  Input.mousePosition.x / Screen.width * screenWidthInUnits;

        //limiting the mouse position x between 1 and 15 units
        float limitMousePos = Mathf.Clamp(mousePos, 1f, 15f);
        
        //set the paddle Position according to the mouse position
        paddlePosition = new Vector2(limitMousePos , transform.position.y);

        transform.position = paddlePosition;


        

    }
}
