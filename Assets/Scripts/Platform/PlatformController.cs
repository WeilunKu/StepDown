using UnityEngine;

public class PlatformController : MonoBehaviour
{
    // Components
    PlatformRise rise;

    // Inspector Values
    [Header("Destroy Object")]
    [SerializeField] float destroyTime = 5f;
    [Space]

    [SerializeField] Vector3 destroyPosition;
    
    
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
        DestroyAtPosition();
    }
    
    
    // === Method === \\
    void DestroyAtPosition()
    {
        float currHeight = gameObject.transform.position.y;
        float targetHeight = destroyPosition.y;
        
        if (currHeight >= targetHeight)
            Destroy(gameObject);
    }
}
