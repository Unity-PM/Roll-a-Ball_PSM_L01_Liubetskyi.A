using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    private Transform player;

    public void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y + 10, player.position.z);
        transform.rotation = Quaternion.Euler(90, 0, 0);
    }
}
