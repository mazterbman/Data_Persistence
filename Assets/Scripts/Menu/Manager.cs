using TMPro;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public static Manager Instance;

    public string NameBest { get { return nameBest; } set { nameBest = value; } }
    private string nameBest = "";

    public string NameNow { get { return nameNow; } set { nameNow = value; } }
    private string nameNow = "";

    public int ScoreBest { get { return scoreBest; } set { scoreBest = value; } }
    private int scoreBest = 0;

    

    private void Awake()
    {
        if (!Instance) Instance = this;
        else Destroy(gameObject);

        DontDestroyOnLoad(gameObject);
        getBestFromPref();
    } 

    public void changeScore(int score)
    {
        if(score >= ScoreBest)
        {
            ScoreBest = score;
            NameBest = nameNow;
            setBestToPref();
        }
    }

    void getBestFromPref()
    {
        NameBest = PlayerPrefs.GetString("BestName","");
        ScoreBest = PlayerPrefs.GetInt("BestScore",0);
    }

    void setBestToPref()
    {
        PlayerPrefs.SetString("BestName", NameBest);
        PlayerPrefs.SetInt("BestScore",ScoreBest);
        PlayerPrefs.Save();
    }
}
