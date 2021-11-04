using UnityEngine;

public class DeadTime : MonoBehaviour
{
    public float LifeTime = 3;
    void Start()
    {
        Destroy(this.gameObject, LifeTime);
    }
}
