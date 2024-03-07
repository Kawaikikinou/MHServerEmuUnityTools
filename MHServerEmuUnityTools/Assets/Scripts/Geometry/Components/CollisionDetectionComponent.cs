using UnityEngine;

public class CollisionDetectionComponent : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision!!");
    }
}
