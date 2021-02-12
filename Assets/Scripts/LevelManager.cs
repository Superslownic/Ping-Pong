using UnityEngine;

namespace PingPong
{
    public class LevelManager : MonoBehaviour
    {
        private IBall _ball;
        private IScore _score;
        private IBallSettingsContainer _ballSettings;

        public void Init(IBall ball, IScore score, IBallSettingsContainer ballSettings)
        {
            _ball = ball;
            _score = score;
            _ballSettings = ballSettings;

            OutTrigger.OnTriggerEnter += OutCallback;
            _ball.OnPaddleTouched += PaddleTouchedCallback;

            ResetBall();
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
            _ball.Setup(_ballSettings.GetRandomBall());
        }

        private void PushBall()
        {
            _ball.Push(Random.insideUnitCircle.normalized);
        }
    }
}
