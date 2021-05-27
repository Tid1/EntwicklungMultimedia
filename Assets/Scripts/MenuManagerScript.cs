using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManagerScript : MonoBehaviour
{
    public GameObject menu;
    private Button returnButton;
    private Button restartButton;
    private bool menuOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        returnButton = GameObject.Find("Return").GetComponent<Button>();
        restartButton = GameObject.Find("Restart").GetComponent<Button>();
        returnButton.onClick.AddListener(unpauseMenu);
        restartButton.onClick.AddListener(reloadScene);
        menu.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuOpen)
            {
                menu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                menu.SetActive(true);
                Time.timeScale = 0;
            }
            menuOpen = !menuOpen;
        }
    }

    private void reloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void unpauseMenu()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
}
