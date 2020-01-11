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

    public Image MyIcon { get => icon;}
    public GameObject MyParent { get => parent; set => parent = value; }

    [SerializeField]
    private Image icon;

    [SerializeField]
    private GameObject parent;

    private GameObject clickedSlot;

    GameObject go;

    private int activeplayfieldindex;

    private int index;

    public void PutOnBoard(Ships ship)
    {
        MyIcon.enabled = true;
        MyIcon.sprite = ship.MyIcon;
        MyIcon.color = Color.white;
        MyIcon.rectTransform.rotation = HandScript.MyInstance.MyIcon.rectTransform.rotation;

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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 40];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 40];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 4];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 4];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 40];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 40];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 4];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 4];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 30];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 3];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 30];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 3];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[3].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 40];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 40];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 4];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 4];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 40];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 40];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 4];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 4];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[0].gameObject.tag == "AC")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[0].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 30];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 3];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 30];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 3];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
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
                if (activeplayfieldindex == 0)
                {

                }
                else
                {

                }
                go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {

                }
                else
                {

                }
                go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {

                }
                else
                {

                }
                go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
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
                if (activeplayfieldindex == 0)
                {

                }
                else
                {

                }
                go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {

                }
                else
                {

                }
                go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {

                }
                else
                {

                }
                go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 30];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 30];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
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
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 3];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 3];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[1].gameObject.tag == "BS")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[1].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
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
        if (HandScript.MyInstance.ShipPart == 1)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 2)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 3)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[2].gameObject.tag == "Sub")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[2].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
    }

    private void Cru()
    {
        if (HandScript.MyInstance.ShipPart == 1)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 2)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[2].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 3)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[3].gameObject.tag == "Cru")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[3].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
    }

    private void Des()
    {
        if (HandScript.MyInstance.ShipPart == 1)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[1].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 2)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
            if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                else
                {
                    go = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1];
                }
                if (ContainerScript.MyInstance.MyAllSlotsScripts[4].gameObject.tag == "Des")
                {
                    go.GetComponent<MainPlayFieldSlotScript>().PutOnBoard(ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponent<Ships>());
                    AllSlotsScript.MyInstance.FromSlot = ContainerScript.MyInstance.MyAllSlotsScripts[4].MyFullship[0].GetComponentInParent<SlotScript>();
                    AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
                    AllSlotsScript.MyInstance.FromSlot = null;
                }
            }
        }
    }
    #endregion

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            if (HandScript.MyInstance.MyMoveable is Ships)
            {
                if (localGameManager.MyInstance.PlayerTurn == 1)
                {
                    activeplayfieldindex = 0;
                }
                else
                {
                    activeplayfieldindex = 1;
                }
                Ships tmp = (Ships)HandScript.MyInstance.MyMoveable;
                clickedSlot = this.gameObject;
                int spaces = tmp.GetComponentInParent<AllSlotsScript>().MySpacesNeeded;
                if (activeplayfieldindex == 0)
                {
                    index = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.FindIndex(b => b == clickedSlot);
                }
                else
                {
                    index = AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.FindIndex(b => b == clickedSlot);
                }

                if (CanPlace(spaces))
                {
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

    private bool CanPlace(int spaces)
    {
        if (HandScript.MyInstance.ShipPart == 1)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                spaces *= 10;
                for (int i = 0; i < spaces; i+=10)
                {
                    if (activeplayfieldindex == 0)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                for (int i = 0; i < spaces; i++)
                {
                    if (activeplayfieldindex == 0)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                spaces *= 10;
                for (int i = spaces; i > 0; i -= 10)
                {
                    if (activeplayfieldindex == 0)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                for (int i = spaces; i > 0; i--)
                {
                    if (activeplayfieldindex == 0)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                    else
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 2)
        {
            spaces -= 1;
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = 0; i < spaces; i += 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = 0; i < spaces; i += 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    for (int i = 0; i < spaces; i++)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    for (int i = 0; i < spaces; i++)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = spaces; i > 0; i -= 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = spaces; i > 0; i -= 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    for (int i = spaces; i > 0; i--)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    for (int i = spaces; i > 0; i--)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 3)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {

                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 20].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {

                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                    {
                        return false;
                    }
                    if (HandScript.MyInstance.ShipType == ShipType.AircraftCarrier || HandScript.MyInstance.ShipType == ShipType.BattleShip)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 2].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 4)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = spaces; i > 0; i -= 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = spaces; i > 0; i -= 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    for (int i = spaces; i > 0; i--)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    for (int i = spaces; i > 0; i--)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = 0; i < spaces; i += 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    spaces *= 10;
                    for (int i = 0; i < spaces; i += 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    for (int i = 0; i < spaces; i++)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName && HandScript.MyInstance.ShipType == ShipType.AircraftCarrier)
                    {
                        return false;
                    }
                    for (int i = 0; i < spaces; i++)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        else if (HandScript.MyInstance.ShipPart == 5)
        {
            if (HandScript.MyInstance.PartRotation.z == 0)
            {
                if (activeplayfieldindex == 0)
                {
                    spaces *= 10;
                    for (int i = spaces; i > 0; i -= 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    spaces *= 10;
                    for (int i = spaces; i > 0; i -= 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 10].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 90)
            {
                if (activeplayfieldindex == 0)
                {
                    for (int i = spaces; i > 0; i--)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = spaces; i > 0; i--)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index - i + 1].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 180)
            {
                if (activeplayfieldindex == 0)
                {
                    spaces *= 10;
                    for (int i = 0; i < spaces; i += 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    spaces *= 10;
                    for (int i = 0; i < spaces; i += 10)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
            else if (HandScript.MyInstance.PartRotation.z == 270)
            {
                if (activeplayfieldindex == 0)
                {
                    for (int i = 0; i < spaces; i++)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < spaces; i++)
                    {
                        if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[index + i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SlotScript.MyInstance.SpriteName)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
}
