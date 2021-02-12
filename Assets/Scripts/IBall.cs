using UnityEngine;

namespace PingPong
{
    public interface IBall
    {
        void SetPosition(Vector3 position);
        void Push(Vector3 direction);
    }
}
