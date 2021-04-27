using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private bool shouldShowOptionButton = true;
    [SerializeField] private GameObject OptionsButton = null;
    [SerializeField] private string levelToLoad = "";
    
    // Start is called before the first frame update
    void Start()
    {
        ShowGameObjects();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowGameObjects()
    {
        if (shouldShowOptionButton == false)
        {
            OptionsButton.SetActive(false);
        }
    }

    public void StartGame()
    {
        if (levelToLoad != "")
        {
            SceneManager.LoadScene(levelToLoad);
        }
        SceneManager.LoadScene(1);
    }

    public void OpenOptionsMenu()
    {
        
    }

    public void CloseOptions()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
