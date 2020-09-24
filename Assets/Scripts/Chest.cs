using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite chestOpenSprite;
    public Sprite chestClosedSprite;
    private bool chestOpen;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        chestOpen = false;
    }

    public void OpenChest()
    {
        spriteRenderer.sprite = (chestOpen) ? chestClosedSprite : chestOpenSprite;
        chestOpen = !chestOpen;
    }
}