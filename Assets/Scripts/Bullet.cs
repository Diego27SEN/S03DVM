using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float TimeBullet = 5f;

    void Start()
    {
        Destroy(gameObject, TimeBullet);
    }
}