using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Vector3 cameraPosition;
    public Vector3 ballPosition;
    public void Start()
    {
       ballPosition = gameObject.GetComponent<MovementController>().transform.position; 
    }
    void Update()
    {
        gameObject.GetComponent<Camera>().transform.position = transform.position + new Vector3(ballPosition.x, ballPosition.y + 40, ballPosition.z);
    }
}
