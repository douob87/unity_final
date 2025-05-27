using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // ✅ 加上這行
using System.Collections;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        text.text = "Score: " + score;

        if (score >= 100)
        {
            SceneManager.LoadScene("END");
        }
    }
}
