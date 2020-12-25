using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveHorizontal, moveVertical;
    [SerializeField]private float moveSpeed = 50f;
    Vector3 deltaMovement = Vector3.zero;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
    }
    //private void FixedUpdate() 
    //{
    //    rb.velocity = new Vector2(moveHorizontal*moveSpeed, moveVertical*moveSpeed);
    //}
    void Move()
    {
        //moveHorizontal = Input.GetAxisRaw("Horizontal");
        //moveVertical = Input.GetAxisRaw("Vertical");  
        this.transform.position += deltaMovement;
    }
}