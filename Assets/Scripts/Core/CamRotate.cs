using UnityEngine;
using UnityEngine.EventSystems;

public class CamRotate : MonoBehaviour, IDragHandler
{
    private Camera cam;


    private void Awake()
    {
        cam = Camera.main;
    }


    public void OnDrag(PointerEventData eventData)
    {
        Vector2 delta = eventData.delta / 10f;

        cam.transform.position = new Vector3();

        cam.transform.Rotate(Vector3.right, -delta.y);
        cam.transform.Rotate(Vector3.up, delta.x);
        cam.transform.Translate(new Vector3(0, 0, -120));
    }
}
