using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MainPlayFieldSlotScript : MonoBehaviour, IPointerClickHandler
{
    private static MainPlayFieldSlotScript instance;

    public static MainPlayFieldSlotScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MainPlayFieldSlotScript>();
            }

            return instance;
        }
    }

    [SerializeField]
    private Image icon;

    private GameObject clickedSlot;

    private int index;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PutOnBoard(Ships ship)
    {
        icon.enabled = true;
        icon.sprite = ship.MyIcon;
        icon.color = Color.white;
        icon.rectTransform.rotation = HandScript.MyInstance.MyIcon.rectTransform.rotation;

        if (HandScript.MyInstance.MyMoveable == (ship as IMoveable))
        {
            HandScript.MyInstance.Drop();
        }
    }

    #region ships
    private void AC()
    {
        if (HandScript.MyInstance.ShipPart == 1)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 40];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 4];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 40];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 4];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 2)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index +20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index +30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 3)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 4)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[4].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 5)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 40];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 4];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 40];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 4];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
    }

    private void BS()
    {
        if (HandScript.MyInstance.ShipPart == 1)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 2)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 3)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 4)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index - 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 30];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 20];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                GameObject go = MainPlayFieldScript.MyInstance.Playslots[index + 3];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 2];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                go = MainPlayFieldScript.MyInstance.Playslots[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
    }

    private void Sub()
    {

    }

    private void Cru()
    {

    }

    private void Des()
    {

    }
    #endregion

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (HandScript.MyInstance.MyMoveable is Ships)
            {
                Ships tmp = (Ships)HandScript.MyInstance.MyMoveable;
                clickedSlot = this.gameObject;
                index = MainPlayFieldScript.MyInstance.Playslots.FindIndex(b => b == clickedSlot);
                PutOnBoard(tmp);

                switch (HandScript.MyInstance.ShipType)
                {
                    case ShipType.AircraftCarrier:
                        AC();
                        break;
                    case ShipType.BattleShip:
                        BS();
                        break;
                    case ShipType.Submarine:
                        Sub();
                        break;
                    case ShipType.Cruiser:
                        Cru();
                        break;
                    case ShipType.Destroyer:
                        Des();
                        break;
                }
            }
        }
    }
}
