using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private CanvasGroup firstMenuButtons, secondMenuButtons, settings;

    [SerializeField]
    private GameObject settingsBackground;

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
        firstMenuButtons.alpha = firstMenuButtons.alpha == 0 ? 1 : 0;
        firstMenuButtons.blocksRaycasts = firstMenuButtons.blocksRaycasts == true ? false : true;
        secondMenuButtons.alpha = secondMenuButtons.alpha == 0 ? 1 : 0;
        secondMenuButtons.blocksRaycasts = secondMenuButtons.blocksRaycasts == true ? false : true;
    }

    public void Settings()
    {
        firstMenuButtons.alpha = firstMenuButtons.alpha == 0 ? 1 : 0;
        firstMenuButtons.blocksRaycasts = firstMenuButtons.blocksRaycasts == true ? false : true;
        settings.alpha = settings.alpha == 0 ? 1 : 0;
        settings.blocksRaycasts = settings.blocksRaycasts == true ? false : true;
        settingsBackground.SetActive(settingsBackground.activeInHierarchy == true ? false : true);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Local()
    {
        SceneManager.LoadScene("LocalGameScene");
    }

    public void VSAI()
    {
        SceneManager.LoadScene("VSAIGameScene");
    }

    public void Multyplayer()
    {
        SceneManager.LoadScene("MultyPlayerScene");
    }
}
