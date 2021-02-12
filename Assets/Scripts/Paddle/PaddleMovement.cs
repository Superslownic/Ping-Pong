using UnityEngine;

namespace PingPong
{
    public class PaddleMovement : MonoBehaviour
    {
        [SerializeField] private float _leftBorder;
        [SerializeField] private float _rightBorder;

        private IInput _input;

        public void Init(IInput input)
        {
            _input = input;
        }

        private void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector3 position = transform.position;
            position.x = _input.TouchPosition.x;
            position.x = Mathf.Clamp(position.x, _leftBorder, _rightBorder);
            transform.position = position;
        }
    }
}
