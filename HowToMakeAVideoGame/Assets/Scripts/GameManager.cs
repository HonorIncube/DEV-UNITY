using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool GameEnded = false; //Booléen PartieFini = faux
    public float restartDelay = 0.35f; //Delay de relancement du jeux 1float
        
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if(GameEnded == false)
        { 
            GameEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
    } // Quand EndGame appeler, appeler restart avec un delay de "restartdelay"

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
