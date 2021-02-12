using System;

namespace PingPong
{
    public interface IScore
    {
        event Action<uint> OnValueChanged;
        event Action<uint> OnBestValueChanged;
        uint CurrentValue { get; }
        uint BestValue { get; set; }
        void Add();
        void Reset();
    }
}
