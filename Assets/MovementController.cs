using UnityEngine;

public class MovementController : MonoBehaviour
{
    Rigidbody m_Rigibody;
    public float m_Thrust = 20f;
    private Vector3 v;
    void Start()
    {
        m_Rigibody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        v = Vector3.zero; // If I will not do this our vector will be moving at the route for infinity
        if (Input.GetKey(KeyCode.UpArrow))
        {
            v += Vector3.forward; // If there will be just v = Vector3.forward; we will not be able to walk in 2 ways like up and right, we will go just a the last pressed way, so to work all buttons we just add to the Vector not just equlize them
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            v += Vector3.back;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            v += Vector3.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            v += Vector3.right;
        }
    }
    void FixedUpdate()
    {
        m_Rigibody.AddForce(v.normalized * m_Thrust); // v.normalized will make our vector normal that means we will have the route 1 and it will move with no speed up
    }
}