using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    GameObject playButton, playButton2, pauseButton, creditsButton, menuButton, menuButton2, quitButton, quitButton2;

    bool Unselected;
    bool Idle = true;

    // Start is called before the first frame update
    void Start() 
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(playButton);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetButtonDown("Pause"))
        {
            if (Time.timeScale == 1 & !Idle)
            {
                Time.timeScale = 0;
                Idle = true;
            }
            else
            {
                Time.timeScale = 1;
                Idle = false;
            }
        }
        if (Unselected) 
        {
            Debug.Log("selection");
            Unselected = false;
            EventSystem.current.SetSelectedGameObject(playButton);
        }
    }

    public void LoadScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Quit() {
        Application.Quit();
    }
}
