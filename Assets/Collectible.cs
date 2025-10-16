using System.Runtime.CompilerServices;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.GetComponent<MovementController>().score += 1;

        int temp_score = collision.gameObject.GetComponent<MovementController>().score;

        if (temp_score == 1)
        {
            Debug.Log("You got your first point!");
        } else if (temp_score == 10)
        {
            Debug.Log("You've collected all the points! Congratulations!");
        } else
        {
            Debug.Log($"You got a point! By now you have: {temp_score}");
        }

        gameObject.SetActive(false);
    }
}
