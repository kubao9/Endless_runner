using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 30;
    public float leftRightSpeed = 4;
    static public bool canMove = false;
    public bool isJumping = false;
    public bool goingDown = false;
    public GameObject playerObject;
    private float jumpStrength = 8;

    private void Start()
    {
        

    }
    void Update()
    {
            transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        if (canMove)
        {
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
                }
            }
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
                {
                    transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
                }
            }


            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space))
            {
               if(isJumping == false)
                {
                    isJumping = true;
                    playerObject.GetComponent<Animator>().Play("Jump");
                    StartCoroutine(JumpSequence());
                }
            }
        }
        if(isJumping)
        {
            if(goingDown == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * jumpStrength, Space.World);
            }
            

            if (goingDown == true)
            {
                transform.Translate(Vector3.down * Time.deltaTime * jumpStrength, Space.World);
            }
        }
    }

    IEnumerator JumpSequence()
    {
        float initialHeight = transform.position.y;
        yield return new WaitForSeconds(0.33f);
        goingDown = true;
        yield return new WaitForSeconds(0.33f);
        isJumping = false;
        goingDown = false;
        if (ObstacleCollision.isCollision == false)
        {
            transform.position = new Vector3(transform.position.x, initialHeight, transform.position.z);
            playerObject.GetComponent<Animator>().Play("Standard Run");
        }
    }
}