using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene"); 
    }


    public void GoToMainMenu()
    {
        SceneManager.LoadScene("startScreen"); 
    }
}
