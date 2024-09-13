using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ForStart : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(loadMainScene);
    }

    void loadMainScene()
    {
        if (Manager.Instance.NameNow != "") 
            SceneManager.LoadScene("main",LoadSceneMode.Single);
    }
}
