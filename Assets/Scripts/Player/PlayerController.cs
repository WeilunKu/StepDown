using UnityEngine;

public class PlayerController : MonoBehaviour
{
// PlayerController
    
// Component
    PlayerMovement move;

// === Life Cycle === //
    void Awake()
    {
        move = GetComponent<PlayerMovement>();
    }

    void FixedUpdate()
    {
        move.Movement();
    }

}
