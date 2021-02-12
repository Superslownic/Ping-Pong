using UnityEngine;
using Utility;

namespace PingPong
{
    public class SaveManager : MonoBehaviour
    {
        private IScore _score;

        public void Init(IScore score)
        {
            _score = score;
            Load();
        }

        private void Load()
        {
            GameData data;
            if (!Serialization.LoadFromBinnary<GameData>(out data)) return;

            _score.BestValue = data.Get<uint>("BestScore");
        }

        private void Save()
        {
            GameData data = new GameData();

            data.Add("BestScore", _score.BestValue);

            Serialization.SaveToBinnary<GameData>(data);
        }

        private void OnApplicationQuit()
        {
            Save();
        }
    }
}
