using UnityEngine;
using TMPro;

public class CoinCollector : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;

    void Start()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: 0";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            score++;
            if (scoreText != null)
            {
                scoreText.text = "Score: " + score;
            }
            Destroy(other.gameObject);
        }
    }
}