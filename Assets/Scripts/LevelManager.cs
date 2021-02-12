using Idler.Presenters;
using UnityEngine;

namespace PingPong
{
    public class LevelManager : MonoBehaviour
    {
        private IBall _ball;
        private IScore _score;

        public void Init(IBall ball, IScore score)
        {
            _ball = ball;
            _score = score;

            OutTrigger.OnTriggerEnter += OutCallback;
            _ball.OnPaddleTouched += PaddleTouchedCallback;
            PushBall();
        }

        private void OnDestroy()
        {
            _ball.OnPaddleTouched -= PaddleTouchedCallback;
            OutTrigger.OnTriggerEnter -= OutCallback;
        }

        private void OutCallback()
        {
            if (_score.CurrentValue > _score.BestValue)
                _score.BestValue = _score.CurrentValue;
            _score.Reset();
            ResetBall();
            PushBall();
        }

        private void PaddleTouchedCallback()
        {
            _score.Add();
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
