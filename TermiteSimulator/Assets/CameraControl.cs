using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("Bounds")]
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    [Header("Camera")]
    public float speed; //start with 20
    private Vector2 motion;

    void Update()
    {
        motion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        transform.Translate(motion * speed * Time.deltaTime);
    }
}
