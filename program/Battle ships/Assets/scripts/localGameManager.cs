using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class localGameManager : MonoBehaviour
{
    private static localGameManager instance;

    public static localGameManager MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<localGameManager>();
            }

            return instance;
        }
    }

    private int playerTurn = 1;

    [SerializeField]
    private Text playerTurnTxt;

    public int PlayerTurn { get => playerTurn; set => playerTurn = value; }

    [SerializeField]
    private Transform[] blocks;

    private float x1, y1, scalex1, scaley1, x2, y2, scalex2, scaley2;

    // Start is called before the first frame update
    void Start()
    {
        x1 = blocks[0].position.x;
        y1 = blocks[0].position.y;
        scalex1 = blocks[0].localScale.x;
        scaley1 = blocks[0].localScale.y;
        x2 = blocks[1].position.x;
        y2 = blocks[1].position.y;
        scalex2 = blocks[1].localScale.x;
        scaley2 = blocks[1].localScale.y;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Ready()
    {
        if (PlacedAll())
        {
            PlayerTurn = 2;
            playerTurnTxt.text = "PLAYER: 2";
            MainPlayFieldScript.MyInstance.player2turn = true;
            foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots1)
            {
                item.GetComponent<MainPlayFieldSlotScript>().MyIcon.enabled = false;
                item.GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().enabled = true;
            AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots2 = AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots2;
            Debug.Log(AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots2.Count);
            Debug.Log(AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyParent);
        }
    }

    private bool PlacedAll()
    {
        foreach (AllSlotsScript item in ContainerScript.MyInstance.MyAllSlotsScripts)
        {
            for (int i = 0; i < item.MySpacesNeeded-1; i++)
            {
                if (item.MyFullship[i].GetComponentInParent<SlotScript>().MyIcon.enabled != false)
                {
                    return false;
                }
            }
        }
        return true;
    }
}
