using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private Sprite chestOpenSprite;
    [SerializeField] private Sprite chestClosedSprite;
    
    private SpriteRenderer _spriteRenderer;
    private bool _chestOpen;
    private bool _chestPrevOpened;
    private Inventory _inventory;
    
    private void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _chestOpen = false;
        _inventory = FindObjectOfType<Inventory>();
        _chestPrevOpened = false;
    }

    public void InteractWithChest()
    {
        _spriteRenderer.sprite = (_chestOpen) ? chestClosedSprite : chestOpenSprite;

        if (!_chestOpen && !_chestPrevOpened)
        {
            _inventory.GiveItem("Diamond Axe");
            _chestPrevOpened = true;
        }
        
        _chestOpen = !_chestOpen;
    }
}