using UnityEngine.EventSystems;

public class GetTouch : EventTrigger
{
    public override void OnPointerDown(PointerEventData eventData)
    {
        CameraController.dragOnScreen = true;
        base.OnPointerDown(eventData);
    }
    public override void OnPointerUp(PointerEventData eventData)
    {
        CameraController.dragOnScreen = false;
        base.OnPointerUp(eventData);
    }
}
