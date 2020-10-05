using UnityEngine;

public class Transition : MonoBehaviour
{
    [SerializeField] private bool horizontalTransition;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player")) return;
        
        if (horizontalTransition)
        {
            var direction = Input.GetAxisRaw("Vertical") * 10;
            if (!(Camera.main is null))
                Camera.main.transform.Translate(0, direction, 0);
        }
        else
        {
            var direction = Input.GetAxisRaw("Horizontal") * 18;
            if (!(Camera.main is null))
                Camera.main.transform.Translate(direction, 0, 0);
        }
    }
}
