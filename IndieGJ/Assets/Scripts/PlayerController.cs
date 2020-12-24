using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveHorizontal, moveVertical;
    [SerializeField]private float moveSpeed = 50f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move();      
    }
    private void FixedUpdate() {
        rb.velocity = new Vector2(moveHorizontal*moveSpeed, moveVertical*moveSpeed);
    }
    void move()
    {
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");  
    }
}