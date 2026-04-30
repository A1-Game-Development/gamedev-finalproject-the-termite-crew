using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("Bounds")]
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    
    [Header("Camera")]
    public float movementSpeed;
    private Vector2 motion;
    public GameObject toTrack;

    void LateUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minX, maxX), Mathf.Clamp(transform.position.y, minY, maxY), -10);
    }
}
