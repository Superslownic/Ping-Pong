using Idler.Presenters;
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
        [SerializeField] private Score _score;
        [SerializeField] private ScorePresenter _scorePresenter;
        [SerializeField] private ScorePresenter _bestScorePresenter;
        [SerializeField] private SaveManager _saveManager;

        private void Awake()
        {
            _score.OnValueChanged += _scorePresenter.Present;
            _score.OnBestValueChanged += _bestScorePresenter.Present;

            _saveManager.Init(_score);
            _paddle1.Init(_playerInput);
            _paddle2.Init(_playerInput);
            _ball.Init();
            _levelManager.Init(_ball, _score);
        }
    }
}
