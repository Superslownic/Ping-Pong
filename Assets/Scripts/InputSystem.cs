using UnityEngine;
using UnityEngine.EventSystems;

namespace PingPong
{
    public class InputSystem : MonoBehaviour, IPointerDownHandler, IDragHandler
    {
        public Vector3 TouchPosition { get; private set; }

        private Camera _camera;
        
        void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
        {
            CalculatePosition(eventData);
        }

        void IDragHandler.OnDrag(PointerEventData eventData)
        {
            CalculatePosition(eventData);
        }

        private void Awake()
        {
            _camera = Camera.main;
        }

        private void CalculatePosition(PointerEventData eventData)
        {
            TouchPosition = _camera.ScreenToWorldPoint(eventData.position);
        }
    }
}
