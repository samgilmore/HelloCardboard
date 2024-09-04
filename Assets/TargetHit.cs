using UnityEngine;
using TMPro;

public class TargetHit : MonoBehaviour
{
    public int pointValue = 10;

    void OnCollisionEnter(Collision collision)
    {
        ScoreManager sm = FindObjectOfType<ScoreManager>();

        if (sm != null)
        {
            TargetManager tm = FindObjectOfType<TargetManager>();

            if (tm != null)
            {
                sm.AddScore(this.pointValue);
            }
        }
    }
}