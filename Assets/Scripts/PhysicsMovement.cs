using UnityEngine;

namespace PingPong
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PhysicsMovement : MonoBehaviour
    {
        [SerializeField] private float _speed;

        public bool IsMoving { get; private set; }
        public Vector2 Direction { get; private set; }

        private Rigidbody2D _rigidbody;

        public void Push(Vector2 direction)
        {
            IsMoving = true;
            Direction = direction;
        }

        public void Stop()
        {
            IsMoving = false;
        }

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (IsMoving == false) return;
            
            _rigidbody.velocity = Direction * _speed;
        }
    }
}
