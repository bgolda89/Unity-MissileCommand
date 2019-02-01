using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour {
    PlayerStats playerStats;
    
    private void Awake()
    {
        playerStats = FindObjectOfType<PlayerStats>();
    }

    public void Replay (){
        playerStats.ResetStats();
        gameObject.SetActive(false);
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }
    public void MainMenu (){
        SceneManager.LoadScene(SceneManager.GetSceneByBuildIndex(1).name);
    }
}
