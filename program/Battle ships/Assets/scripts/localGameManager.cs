﻿using System.Collections;
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

    private int player1Hits, player2Hits;

    private bool startGame = false;

    private Camera mainCamera;

    [SerializeField]
    private Text playerTurnTxt;

    [SerializeField]
    private GameObject readybtn;

    public int PlayerTurn { get => playerTurn; set => playerTurn = value; }

    public int Player1Hits { get => player1Hits; set => player1Hits = value; }

    public int Player2Hits { get => player2Hits; set => player2Hits = value; }

    [SerializeField]
    private Transform[] blocks;

    private float x1, y1, scalex1, scaley1, x2, y2, scalex2, scaley2;

    // Start is called before the first frame update
    void Start()
    {
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
            }
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


    private void ClickTarget()
    {
        if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            //Makes a raycast from the mouse position into the game world
            RaycastHit2D hit = Physics2D.Raycast(Input.mousePosition, Vector2.zero, Mathf.Infinity);

            if (hit.collider != null)
            {
                IInteractable entity = hit.collider.gameObject.GetComponent<IInteractable>();
                if (hit.collider != null && hit.collider.tag == "Interactable")
                {
                    entity.Interact();
                }
            }
            if (playerTurn == 1)
            {
                playerTurn = 2;
                playerTurnTxt.text = "PLAYER: 2";

                AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.position = new Vector2(x2, y2);
                AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.localScale = new Vector3(scalex2, scaley2, 0);
                AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.position = new Vector2(x1, y1);
                AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.localScale = new Vector3(scalex1, scaley1, 0);
                if (Player1Hits == 17)
                {
                    StartCoroutine(WinPlayer1());
                }
            }
            else if (playerTurn == 2)
            {
                playerTurn = 1;
                playerTurnTxt.text = "PLAYER: 1";

                AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.position = new Vector2(x2, y2);
                AllPlayFieldsScript.MyInstance.MyPlayfield[0].transform.localScale = new Vector3(scalex2, scaley2, 0);
                AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.position = new Vector2(x1, y1);
                AllPlayFieldsScript.MyInstance.MyPlayfield[1].transform.localScale = new Vector3(scalex1, scaley1, 0);
                if (Player2Hits == 17)
                {

                }
            }
        }
    }

    private IEnumerator WinPlayer1()
    {

        yield return new WaitForSeconds(3);
    }
}
