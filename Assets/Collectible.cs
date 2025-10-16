using System.Runtime.CompilerServices;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        collision.gameObject.GetComponent<GameMaster>().setScore(1);
        collision.gameObject.GetComponent<GameMaster>().writeScore();

        gameObject.SetActive(false);
    }
}
