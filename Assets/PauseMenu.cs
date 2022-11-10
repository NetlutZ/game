using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;
    [SerializeField] string sceneName;
    void Start(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPause){
                Resume();
            }
            else{
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("StartGame");
    }

    public void QuitGame(){
        Application.Quit();
    }

    public void Restart(){
        SceneManager.LoadScene(sceneName);
    }
}
