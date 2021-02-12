using UnityEngine;

namespace PingPong
{
    [CreateAssetMenu]
    public class BallSettings : ScriptableObject
    {
        public Color color;
        public float speed;
        public Vector3 size;
    }
}
