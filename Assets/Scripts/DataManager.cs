using UnityEngine;

namespace PingPong
{
    public class DataManager : MonoBehaviour, IBallSettingsContainer
    {
        [SerializeField] private BallSettings[] _ballSettings;

        public BallSettings GetRandomBall()
        {
            return _ballSettings[Random.Range(0, _ballSettings.Length)];
        }
    }
}
