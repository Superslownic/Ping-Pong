using System;
using UnityEngine;

namespace PingPong
{
    public class Score : MonoBehaviour, IScore
    {
        public event Action<uint> OnValueChanged;
        public event Action<uint> OnBestValueChanged;

        public uint BestValue
        {
            get => _bestValue;

            set
            {
                _bestValue = value;
                OnBestValueChanged?.Invoke(_bestValue);
            }
        }
        public uint CurrentValue
        {
            get => _value;

            private set
            {
                _value = value;
                OnValueChanged?.Invoke(_value);
            }
        }

        private uint _value;
        private uint _bestValue;
        
        void IScore.Add()
        {
            CurrentValue++;
        }

        void IScore.Reset()
        {
            CurrentValue = 0;
        }
    }
}
