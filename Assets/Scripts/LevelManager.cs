using UnityEngine;

namespace PingPong
{
    public class LevelManager : MonoBehaviour
    {
        private IBall _ball;

        public void Init(IBall ball)
        {
            _ball = ball;
            
            OutTrigger.OnTriggerEnter += OutCallback; //For singleplayer
            PushBall();
        }

        private void OnDestroy()
        {
            OutTrigger.OnTriggerEnter -= OutCallback;
        }

        private void OutCallback()
        {
            ResetBall();
            PushBall();
        }

        private void ResetBall()
        {
            _ball.SetPosition(Vector2.zero);
        }

        private void PushBall()
        {
            _ball.Push(Random.insideUnitCircle.normalized);
        }
    }
}
