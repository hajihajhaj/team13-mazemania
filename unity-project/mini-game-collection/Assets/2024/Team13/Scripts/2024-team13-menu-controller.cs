using UnityEngine;
using UnityEngine.SceneManagement;
namespace MiniGameCollection.Games2024.Team13
{
    public class MenuController : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("2024-team13-game");
        }
        public void GoToMainMenu()
        {
            SceneManager.LoadScene("2024-team13-start");
        }
    }
}