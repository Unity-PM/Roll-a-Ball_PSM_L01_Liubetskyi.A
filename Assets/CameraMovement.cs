using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Vector3 ballPosition;
    private Vector3 dist;
    public void Start()
    {
       ballPosition = gameObject.GetComponent<MovementController>().transform.position; 
       dist = transform.position - ballPosition;
    }
    void Update()
    {
        transform.position = ballPosition + dist;
    }
}
