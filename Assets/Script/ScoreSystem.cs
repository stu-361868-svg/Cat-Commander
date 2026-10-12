using UnityEngine;
using UnityEngine.UI;
public class ScoreSystem : MonoBehaviour
{
    public float score;
    public Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
    }

    public void AddScore()
    {
        score++;
    }

}
