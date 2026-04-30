using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [Header("Bounds")]
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    
    [Header("Input")]
    public float horizontalInput = Input.GetAxis("Horizontal");
    public float verticalInput = Input.GetAxis("Vertical");

    [Header("Camera")]
    public float movementSpeed;
    private Vector2 motion;
    public GameObject toTrack;

    void LateUpdate()
    {
        // motion = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        // transform.Translate(motion * movementSpeed * Time.deltaTime);
        // transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, -10);

        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, -10);
        // Mathf.Clamp(transform.position.x, maxX, minX);
        // Mathf.Clamp(transform.position.y, maxY, minY);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, maxX, minX), Mathf.Clamp(transform.position.y, maxY, minY), -10);
    }
}
