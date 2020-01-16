using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
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

    private int player1Hits, player2Hits, missesPlayer1, missesPlayer2, turnsPlayer1, turnsPlayer2;

    [SerializeField]
    private Image player1WinBanner, player2WinBanner;

    private bool startGame = false;

    private bool turnTaken;

    private Camera mainCamera;

    [SerializeField]
    private Text playerTurnTxt;

    [SerializeField]
    private GameObject readybtn;

    public int PlayerTurn { get => playerTurn; set => playerTurn = value; }

    public int Player1Hits { get => player1Hits; set => player1Hits = value; }

    public int Player2Hits { get => player2Hits; set => player2Hits = value; }

    public int MissesPlayer1 { get => missesPlayer1; set => missesPlayer1 = value; }

    public int MissesPlayer2 { get => missesPlayer2; set => missesPlayer2 = value; }

    public int TurnsPlayer1 { get => turnsPlayer1; set => turnsPlayer1 = value; }

    public int TurnsPlayer2 { get => turnsPlayer2; set => turnsPlayer2 = value; }

    [SerializeField]
    private Transform[] blocks;

    private float x1, y1, scalex1, scaley1, x2, y2, scalex2, scaley2;

    // Start is called before the first frame update
    void Start()
    {
        //setting the main camara and getting the bounds as 
        mainCamera = Camera.main;
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
        if (startGame)
        {
            ClickTarget();
        }
    }

    //
    public void Ready()
    {
        if (PlacedAll())
        {
            if (playerTurn == 1)
            {
                PlayerTurn = 2;
                playerTurnTxt.text = "PLAYER: 2";
                MainPlayFieldScript.MyInstance.player2turn = true;
                foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots1)
                {
                    item.GetComponent<MainPlayFieldSlotScript>().MyIcon.enabled = false;
                    item.GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.position = new Vector2(x2, y2);
                AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.localScale = new Vector3(scalex2, scaley2, 0);
                AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.position = new Vector2(x1, y1);
                AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.localScale = new Vector3(scalex1, scaley1, 0);
                AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().enabled = true;
                AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots1 = AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots2;
                AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots2.Clear();
                foreach (AllSlotsScript item in ContainerScript.MyInstance.MyAllSlotsScripts)
                {
                    for (int i = 0; i < item.MySpacesNeeded; i++)
                    {
                        item.MyFullship[i].GetComponentInParent<SlotScript>().MyIcon.enabled = true;
                    }
                }
            }
            else if(playerTurn == 2)
            {
                readybtn.SetActive(false);
                startGame = true;
                PlayerTurn = 1;
                playerTurnTxt.text = "PLAYER: 1";
                MainPlayFieldScript.MyInstance.player2turn = false;
                foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots2)
                {
                    item.GetComponent<MainPlayFieldSlotScript>().MyIcon.enabled = false;
                }
                foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots1)
                {
                    item.GetComponent<BoxCollider2D>().enabled = false;
                }
                foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots2)
                {
                    item.GetComponent<BoxCollider2D>().enabled = true;
                }
            }
        }
    }

    //
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

    //
    private void ClickTarget()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject() && !turnTaken)
        {
            //Makes a raycast from the mouse position into the game world
            RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.zero, Mathf.Infinity);

            if (hit.collider != null)
            {
                IInteractable entity = hit.collider.gameObject.GetComponent<IInteractable>();
                if (hit.collider != null && hit.collider.tag == "Interactable")
                {
                    turnTaken = true;
                    entity.Interact();
                    StartCoroutine(TimeBetweenPlayers());
                }
            }
        }
    }
    
    private IEnumerator WinPlayer1()
    {
        player1WinBanner.enabled = true;
        yield return new WaitForSeconds(3);
        EndScreenManager.MyInstance.endScreenStatsShow();
    }
    
    private IEnumerator WinPlayer2()
    {
        player2WinBanner.enabled = true;
        yield return new WaitForSeconds(3);
        EndScreenManager.MyInstance.endScreenStatsShow();
    }

    //this determents the time it takes between turns
    private IEnumerator TimeBetweenPlayers()
    {
        yield return new WaitForSeconds(1);
        if (playerTurn == 1)
        {
            playerTurn = 2;
            playerTurnTxt.text = "PLAYER: 2";
            TurnsPlayer1++;

            AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.position = new Vector2(x2, y2);
            AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.localScale = new Vector3(scalex2, scaley2, 0);
            AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.position = new Vector2(x1, y1);
            AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.localScale = new Vector3(scalex1, scaley1, 0);
            foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots2)
            {
                item.GetComponent<BoxCollider2D>().enabled = false;
            }
            foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots1)
            {
                if (item.GetComponentInChildren<MainPlayFieldSlotScript>().MyIcon.enabled != true)
                {
                    item.GetComponent<BoxCollider2D>().enabled = true;
                }
            }
            if (Player1Hits == 17)
            {
                StartCoroutine(WinPlayer1());
            }
        }
        else if (playerTurn == 2)
        {
            playerTurn = 1;
            playerTurnTxt.text = "PLAYER: 1";
            TurnsPlayer2++;

            AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.position = new Vector2(x2, y2);
            AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.localScale = new Vector3(scalex2, scaley2, 0);
            AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.position = new Vector2(x1, y1);
            AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.localScale = new Vector3(scalex1, scaley1, 0);
            foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponent<MainPlayFieldScript>().Playslots1)
            {
                item.GetComponent<BoxCollider2D>().enabled = false;
            }
            foreach (GameObject item in AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponent<MainPlayFieldScript>().Playslots2)
            {
                if (item.GetComponentInChildren<MainPlayFieldSlotScript>().MyIcon.enabled != true)
                {
                    item.GetComponent<BoxCollider2D>().enabled = true;
                }
            }
            if (Player2Hits == 17)
            {
                StartCoroutine(WinPlayer2());
            }
        }
        turnTaken = false;
    }
}
