using UnityEngine;

namespace PingPong
{
    public class Injector : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private PaddleMovement _paddle1;
        [SerializeField] private PaddleMovement _paddle2;

        private void Awake()
        {
            _paddle1.Init(_playerInput);
            _paddle2.Init(_playerInput);
        }
    }
}
