using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class MenuSelect : MonoBehaviour
{   
    public void SelectMenu1()
    {
        SceneManager.LoadScene("Menu1");
    }
    public void SelectMenu2()
    {
        SceneManager.LoadScene("Menu2");
    }
    public void SelectMenu3()
    {
        SceneManager.LoadScene("Menu3");
    }
}
