using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int CurrentScore = 0;

    public Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = CurrentScore.ToString();
    }
}
