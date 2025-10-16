using UnityEngine;

public class Cuboin_Rotation : MonoBehaviour
{
    public float speed = 150;
    private float alpha;

    void Update()
    {
       float angle = speed * Time.deltaTime;

       alpha = alpha + angle;

       transform.rotation = Quaternion.Euler(0, -alpha, alpha);
    }
}

