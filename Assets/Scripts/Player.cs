using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public int maxHealth;
    private int health;
    private Vector2 moveAmount;
    private Rigidbody2D rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health = maxHealth;
    }

    public void getMovement()
    {
        moveAmount = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveAmount = moveAmount.normalized * speed;
    }

    public void move()
    {
        rb.MovePosition(rb.position + moveAmount*Time.deltaTime);
    }

    public void takeDamage(int damage)
    {
        health -= damage;
        //update the ui/gamemanager
        print("Health: "+health); //for debugging
    }

    // Update is called once per frame
    void Update()
    {
        getMovement();
    }

    private void FixedUpdate()
    {
        move();
    }
}
