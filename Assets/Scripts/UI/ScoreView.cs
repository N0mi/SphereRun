using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{
    private Text ScoreTxt;

    private void Awake()
    {
        ScoreTxt = GetComponent<Text>();
    }

    private void Update()
    {
        ScoreTxt.text = ScoreManager.Score.ToString();
    }
}
