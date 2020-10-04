using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private int maxHp;
    [SerializeField] private int xpToNextLevel;
    [SerializeField] private int attackPower;
    [SerializeField] private int defencePower;
    [SerializeField] private float interactRange;
    
    
    private Rigidbody2D _rigidBody;
    private int _currentHp;
    private int _currentXp;
    private Vector2 _facingDirection;


    private void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
        _currentHp = maxHp;
        _currentXp = 0;
    }

    private void Update()
    {
        Move();
        CheckInteract();
    }

    private void Move()
    {
        var x = Input.GetAxisRaw("Horizontal");
        var y = Input.GetAxisRaw("Vertical");
        var velocity = new Vector2(x, y);

        if (velocity.magnitude != 0)
            _facingDirection = velocity;

        _rigidBody.velocity = velocity * moveSpeed;
    }

    private void CheckInteract()
    {
        var cast = Physics2D.Raycast(transform.position, _facingDirection, interactRange, 1 << 8);

        if (cast.collider == null) return;
        var interactable = cast.collider.GetComponent<Interactable>();
        if (Input.GetKeyDown(KeyCode.E))
            interactable.Interact();
    }
}