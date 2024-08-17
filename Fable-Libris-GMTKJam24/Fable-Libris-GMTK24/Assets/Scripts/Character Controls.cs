using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControls : MonoBehaviour 
{
    public Rigidbody2D rb;
    public GameObject character;
    public bool canMove;
    public int moveSpeed;
    public int life;
   
    // Start is called before the first frame update
    void Start()
    {
        canMove = true;
        if (rb == null) rb = GetComponent<Rigidbody2D>();
        else
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove == true)
        {
            if (Input.GetKeyDown(KeyCode.A) || (Input.GetKeyDown(KeyCode.LeftArrow))){
                rb.AddForce(new Vector2(-1 * moveSpeed, 0));
            }
            if (Input.GetKeyDown(KeyCode.D) || (Input.GetKeyDown(KeyCode.RightArrow)))
            {
                rb.AddForce(new Vector2(moveSpeed, 0));
            }
            if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.UpArrow)))
            {
                rb.AddForce(new Vector2(0, moveSpeed));
            }
            if (Input.GetKeyDown(KeyCode.S) || (Input.GetKeyDown(KeyCode.DownArrow)))
            {
                rb.AddForce(new Vector2(0, -1*moveSpeed));
            }
            else if (Input.GetKeyUp(KeyCode.A) || (Input.GetKeyUp(KeyCode.LeftArrow)))
            {
                float y = rb.velocity.y;
                rb.velocity = new Vector2(0,y);
            }
            else if (Input.GetKeyUp(KeyCode.D) || (Input.GetKeyUp(KeyCode.RightArrow)))
            {
                float y = rb.velocity.y;
                rb.velocity = new Vector2(0, y);
            }
            else if (Input.GetKeyUp(KeyCode.W) || (Input.GetKeyUp(KeyCode.UpArrow)))
            {
                float x = rb.velocity.x;
                rb.velocity = new Vector2(x, 0);
            }
            else if (Input.GetKeyUp(KeyCode.S) || (Input.GetKeyUp(KeyCode.DownArrow)))
            {
                float x = rb.velocity.x;
                rb.velocity = new Vector2(x, 0);
            }
        }
        else
        {
            return;
        }
    }
}
