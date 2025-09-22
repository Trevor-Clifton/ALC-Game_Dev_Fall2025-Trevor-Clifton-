using UnityEngine;

public class CleanUpParticles : MonoBehaviour
{
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 2f;
        Destroy(gameObject, timer);
    }
}
