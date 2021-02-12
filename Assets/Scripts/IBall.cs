using System;
using UnityEngine;

namespace PingPong
{
    public interface IBall
    {
        event Action OnPaddleTouched;
        void SetPosition(Vector3 position);
        void Push(Vector3 direction);
    }
}
