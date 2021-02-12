using System;
using UnityEngine;

namespace PingPong
{
    public class OutTrigger : MonoBehaviour
    {
        public static event Action OnTriggerEnter;

        private void OnTriggerEnter2D(Collider2D other)
        {
            if(other.HasComponent<IBall>())
                OnTriggerEnter?.Invoke();
        }
    }
}
