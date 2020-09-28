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

    [Header("Sprites")]
    public Sprite body;
    public Sprite hair;
    public Sprite shirt;
    public Sprite pants;
    public Sprite shoes;
    public Sprite weapon;
    public Sprite shield;

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
        RaycastHit2D cast = Physics2D.Raycast(transform.position, facingDirection, interactRange, 1 << 8);

        if (cast.collider != null)
        {
            Interactable interactable = cast.collider.GetComponent<Interactable>();

            if (Input.GetKeyDown(KeyCode.E))
                interactable.Interact();
        }
    }
}