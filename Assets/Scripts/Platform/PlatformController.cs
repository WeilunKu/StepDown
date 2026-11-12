using UnityEngine;

public class PlatformController : MonoBehaviour
{
// PlatformController

// Awake
    PlatformRise rise;

// Inspector
    [SerializeField] float destroyTime = 5f;

// === Life Cycle === //
    void Awake()
    {
        rise = GetComponent<PlatformRise>();
    }

    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    void Update()
    {
        rise.Rising();
    }

}
