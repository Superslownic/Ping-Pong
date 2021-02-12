using UnityEngine;

namespace PingPong
{
    [RequireComponent(typeof(PaddleMovement))]
    public class Paddle : MonoBehaviour
    {
        private PaddleMovement _paddleMovement;
        private IInput _input;

        public void Init(IInput input)
        {
            _input = input;
            _paddleMovement = GetComponent<PaddleMovement>();
            _paddleMovement.Init(input);
        }
    }
}
