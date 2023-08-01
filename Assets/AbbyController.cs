using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbbyController : MonoBehaviour
{

public float speed = 2.0f;
    private Rigidbody2D rigidbody2d;
    float horizontal; 
float vertical;
Vector2 lookDirection = new Vector2(1,0);

    public Rigidbody2D Rigidbody2d { get => rigidbody2d; set => rigidbody2d = value; }

    // Start is called before the first frame update
    void Start()
    {
         rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
	//gets the actual axis input from the keyboard WASD or <^v>.
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        }
    void FixedUpdate()
    {


        //this is for movement, it takes the current position of the rigid body and calls for the transformation. Adding horizontal to the mix means that when we put in actually inputs, she'll move. 
        Vector2 position = GetComponent<Rigidbody2D>().position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        // repeated for vertical movements
        position.y = position.y + speed * vertical * Time.deltaTime;
        // the new transformed position, is now the new position. its like math, n = n+1
        GetComponent<Rigidbody2D>().MovePosition(position);
        //you don't fully copy the code for creating y, since the position is already defined in vector 2, so it can't be redefined, or doesn't need to be, really.  
        //use TDT to run the animation independently from frame rate, so the mac users can keep up.

    }
}

