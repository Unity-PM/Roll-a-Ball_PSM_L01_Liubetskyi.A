using UnityEngine;

public class GameMaster : MonoBehaviour
{
    private int score;

    public void setScore(int score)
    {
        this.score += score;
    }

    public int getScore()
    {
        return this.score;
    }

    public void writeScore()
    {
        if (score == 1)
        {
            Debug.Log("You've got the first point, keep it going!");
        }
        else if (score == 10)
        {
            Debug.Log("You've won! You got all points!");
        }
        else
        {
            Debug.Log($"Keep it going! You now have: {score}");
        }
    }
}
