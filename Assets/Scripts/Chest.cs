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
    private bool ChestPrevOpened;

    private void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        chestOpen = false;
        inventory = FindObjectOfType<Inventory>();
        ChestPrevOpened = false;
    }

    public void InteractWithChest()
    {
        spriteRenderer.sprite = (chestOpen) ? chestClosedSprite : chestOpenSprite;

        if (!chestOpen && !ChestPrevOpened)
        {
            inventory.GiveItem("Diamond Axe");
            ChestPrevOpened = true;
        }
        
        chestOpen = !chestOpen;
    }
}