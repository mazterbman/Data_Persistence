using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ForExit : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(exitGame);
    }

#if UNITY_EDITOR
    void exitGame()
    {
        UnityEditor.EditorApplication.ExitPlaymode();
    }
#else
    void exitGame()
    {
       Application.Quit();
    }
#endif
}
