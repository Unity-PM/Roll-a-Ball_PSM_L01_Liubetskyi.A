using UnityEngine;

public class MovementController : MonoBehaviour
{
    Rigidbody m_Rigibody;
    public float m_Thrust = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Rigibody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            m_Rigibody.AddForce(Vector3.forward * m_Thrust);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            m_Rigibody.AddForce(Vector3.back * m_Thrust);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            m_Rigibody.AddForce(Vector3.left * m_Thrust);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            m_Rigibody.AddForce(Vector3.right * m_Thrust);
        }
    }
}
