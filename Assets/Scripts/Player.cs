using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 moveAmount;
    private int health;
    [SerializeField] private int maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        health=maxHealth;
    }

    public void getMovement()
    {
        //Set the moveAmount array (get user input)
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical"));
        moveAmount = input.normalized*speed;
    }

    public void move()
    {
        //actually moves using the rigidbody
        getMovement();
        rb.MovePosition(rb.position+moveAmount*Time.deltaTime);
    }

    public void takeDamage(int amt)
    {
        health -= amt;
        if(health <= 0)
        {
            print("Game Over");
        }
    }
  
}
