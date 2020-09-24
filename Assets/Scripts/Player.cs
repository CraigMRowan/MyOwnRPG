using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    public float moveSpeed;
    public int maxHP;
    private int currentHP;
    private int currentXP;
    public int xpToNextLevel;
    public int attackPower;
    public int defencePower;
    private Vector2 facingDirection;
    public float interactRange;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        currentHP = maxHP;
        currentXP = 0;
    }

    void Update()
    {
        Move();
        CheckInteract();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 velocity = new Vector2(x, y);

        if (velocity.magnitude != 0)
            facingDirection = velocity;

        rigidBody.velocity = velocity * moveSpeed;
    }

    void CheckInteract()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, facingDirection, interactRange, 1 << 8);

        if (hit.collider != null)
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (Input.GetKeyDown(KeyCode.E))
                interactable.Interact();
        }
    }
}