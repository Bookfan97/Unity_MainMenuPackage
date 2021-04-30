using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [Header("Toggles")]
    [SerializeField] private bool shouldShowOption = true;
    [SerializeField] private bool shouldGraphicsOptions = true;
    [SerializeField] private bool shouldAudioOptions = true;
    [Header("Main Menu")]
    [SerializeField] private GameObject OptionsButton = null;
    [SerializeField] private GameObject optionsScreen = null;
    [SerializeField] private string levelToLoad = "";
    [Header("Options Menu")]
    [SerializeField] private GameObject graphicsLabel = null;
    [SerializeField] private GameObject graphicsOptions = null;
    [SerializeField] private GameObject graphicsApplyButton = null;
    [SerializeField] private GameObject audioLabel = null;
    [SerializeField] private GameObject audioOptions = null;
    
    // Start is called before the first frame update
    void Start()
    {
        ShowGameObjects();
        optionsScreen.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowGameObjects()
    {
        OptionsButton.SetActive(shouldShowOption);
        graphicsLabel.SetActive(shouldGraphicsOptions);
        graphicsOptions.SetActive(shouldGraphicsOptions);
        graphicsApplyButton.SetActive(shouldGraphicsOptions);
        audioLabel.SetActive(shouldAudioOptions);
        audioOptions.SetActive(shouldAudioOptions);
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
        if (optionsScreen.gameObject.activeInHierarchy)
        {
            optionsScreen.SetActive(false);
        }
        else
        {
            optionsScreen.SetActive(true);
        }
    }

    public void CloseOptions()
    {
        
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
