using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup firstMenuButtons, secondMenuButtons, settings;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene("Gamescene");
    }

    public void Settings()
    {
        firstMenuButtons.alpha = firstMenuButtons.alpha == 0 ? 1 : 0;
        firstMenuButtons.blocksRaycasts = firstMenuButtons.blocksRaycasts == true ? false : true;
        settings.alpha = settings.alpha == 0 ? 1 : 0;
        settings.blocksRaycasts = settings.blocksRaycasts == true ? false : true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
