using UnityEngine;

namespace PingPong
{
    public static class Extensions
    {
        public static bool HasComponent<T>(this Component component)
        {
            return component.GetComponent<T>() != null;
        }

        public static bool HasComponent<T>(this GameObject gameObject)
        {
            return gameObject.GetComponent<T>() != null;
        }
    }
}
