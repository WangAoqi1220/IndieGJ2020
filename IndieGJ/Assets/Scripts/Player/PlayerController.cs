using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField]private float moveSpeed = 10f;
    private Vector3 deltaMovement;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.anyKeyDown)
        {
            ComputeMovement();
            Move();
        }
    }
    void Move()
    {
        this.transform.position += deltaMovement;
    }
    void ComputeMovement()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            deltaMovement = new Vector3(0, moveSpeed, 0);
        else if (Input.GetKey(KeyCode.DownArrow))
            deltaMovement = new Vector3(0, -moveSpeed, 0);
        else if (Input.GetKey(KeyCode.LeftArrow))
            deltaMovement = new Vector3(-moveSpeed, 0, 0);
        else if (Input.GetKey(KeyCode.RightArrow))
            deltaMovement = new Vector3(moveSpeed, 0, 0);
    }
}