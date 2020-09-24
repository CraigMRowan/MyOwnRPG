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

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        currentHP = maxHP;
        currentXP = 0;
    }

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 velocity = new Vector2(x, y);

        rigidBody.velocity = velocity * moveSpeed;
    }
}