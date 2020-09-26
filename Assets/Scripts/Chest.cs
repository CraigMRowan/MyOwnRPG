using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite chestOpenSprite;
    public Sprite chestClosedSprite;
    private bool chestOpen;
    Inventory inventory;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        chestOpen = false;
        inventory = FindObjectOfType<Inventory>();
    }

    public void OpenChest()
    {
        spriteRenderer.sprite = (chestOpen) ? chestClosedSprite : chestOpenSprite;
        chestOpen = !chestOpen;
        inventory.GiveItem("Diamond Axe");
    }
}