using UnityEngine;

namespace Assets.Scripts.Geometry
{
    public class CollisionDetectionComponent : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Collision!!");
        }
    }
}
