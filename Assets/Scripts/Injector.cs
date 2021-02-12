using UnityEngine;

namespace PingPong
{
    public class Injector : MonoBehaviour
    {
        [SerializeField] private PlayerInput _playerInput;
        [SerializeField] private Paddle _paddle1;
        [SerializeField] private Paddle _paddle2;
        [SerializeField] private LevelManager _levelManager;
        [SerializeField] private Ball _ball;

        private void Awake()
        {
            _paddle1.Init(_playerInput);
            _paddle2.Init(_playerInput);
            _ball.Init();
            _levelManager.Init(_ball);
        }
    }
}
