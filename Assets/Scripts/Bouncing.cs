using UnityEngine;

namespace PingPong
{
    [RequireComponent(typeof(PhysicsMovement))]
    public class Bouncing : MonoBehaviour
    {
        private PhysicsMovement _physicsMovement;

        private void Awake()
        {
            _physicsMovement = GetComponent<PhysicsMovement>();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Vector2 normal = collision.contacts[0].normal;
            _physicsMovement.Move(Vector2.Reflect(_physicsMovement.Direction, normal));
        }
    }
}
