using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    private static EndScreenManager instance;

    public static EndScreenManager MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<EndScreenManager>();
            }

            return instance;
        }
    }

    [SerializeField]
    private Text hitsPlayer1Txt, hitsPlayer2Txt, missesPlayer1Txt, missesPlayer2Txt, turnsPlayer1Txt, turnsPlayer2Txt;

    [SerializeField]
    private CanvasGroup endScreen;

    public void endScreenStatsShow()
    {
        endScreen.alpha = 1;
        endScreen.blocksRaycasts = true;
        hitsPlayer1Txt.text = string.Format("Hits:" + localGameManager.MyInstance.Player1Hits);
        hitsPlayer2Txt.text = string.Format("Hits:" + localGameManager.MyInstance.Player2Hits);
        missesPlayer1Txt.text = string.Format("Misses:" + localGameManager.MyInstance.MissesPlayer1);
        missesPlayer2Txt.text = string.Format("Misses:" + localGameManager.MyInstance.MissesPlayer2);
        turnsPlayer1Txt.text = string.Format("Turns:" + localGameManager.MyInstance.TurnsPlayer1);
        turnsPlayer2Txt.text = string.Format("Turns:" + localGameManager.MyInstance.TurnsPlayer2);
    }

    public void Return()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
