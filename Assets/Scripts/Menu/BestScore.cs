using TMPro;
using UnityEngine;

public class BestScore : MonoBehaviour
{
    [SerializeField] Manager manager;
    TMP_Text bestScoreText;

    private void Start()
    {
        manager = Manager.Instance;
        bestScoreText = GetComponent<TMP_Text>();
        SetScoreText();
    }

    public void SetScoreText()
    {
        string fullText = "BEST SCORE : ";

        if (manager.NameBest != "")
        {
            fullText += manager.NameBest;
            fullText += " => " + manager.ScoreBest.ToString();
        }

        bestScoreText.text = fullText;
    }
}
