using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Pedal : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private UnityEvent _onMouse;

    private bool isMouseDown;

    private void Update()
    {
        if (isMouseDown)
        {
            _onMouse.Invoke();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isMouseDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isMouseDown = false;
    }
}
