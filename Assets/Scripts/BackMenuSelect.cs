using UnityEngine;

public class BackMenuSelect : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void BackToMenuSelect()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MenuSelect");
    }
}
