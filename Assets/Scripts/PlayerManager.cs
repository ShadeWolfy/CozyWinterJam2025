using System;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;
    [HideInInspector] public Vector2 moveDir;
    [HideInInspector] public float health;
    [HideInInspector] public float attackDamage;
    [HideInInspector] public float attackSpeed;
    
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        InputManager();
        Debug.Log(rb.velocity);

    }

    private void FixedUpdate()
    {
        Move();
    }

    private void InputManager()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;
    }

    private void Move()
    {
        rb.velocity = new Vector2(moveDir.x * moveSpeed, moveDir.y * moveSpeed);
    }
}
