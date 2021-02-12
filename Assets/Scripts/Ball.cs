using System;
using UnityEngine;

namespace PingPong
{
    [RequireComponent(typeof(PhysicsMovement))]
    [RequireComponent(typeof(Bouncing))]
    public class Ball : MonoBehaviour, IBall
    {
        public event Action OnPaddleTouched;

        private PhysicsMovement _physicsMovement;
        private Bouncing _bouncing;
        
        void IBall.Push(Vector3 direction)
        {
            _physicsMovement.Push(direction);
        }

        void IBall.SetPosition(Vector3 position)
        {
            transform.position = position;
        }

        public void Init()
        {
            _physicsMovement = GetComponent<PhysicsMovement>();
            _bouncing = GetComponent<Bouncing>();
            _bouncing.OnBounce += BounceCallback;
        }

        private void OnDestroy()
        {
            _bouncing.OnBounce -= BounceCallback;
        }

        private void BounceCallback(Transform other)
        {
            if (other.HasComponent<Paddle>())
                OnPaddleTouched?.Invoke();
        }
    }
}
