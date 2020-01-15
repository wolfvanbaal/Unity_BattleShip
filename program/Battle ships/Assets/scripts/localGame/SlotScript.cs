using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour, IPointerClickHandler
{
    private static SlotScript instance;

    public static SlotScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SlotScript>();
            }

            return instance;
        }
    }

    [SerializeField]
    private Image icon;

    private int activeplayfieldindex;

    [SerializeField]
    private Sprite spriteName;

    public Ships Myship
    {
        get
        {
            return GetComponentInChildren<Ships>();
        }
    }

    public Image MyIcon { get => icon; }
    public Sprite SpriteName { get => spriteName; set => spriteName = value; }

    //this executes when you want to pick up a ship to place it on the main grid
    public void OnPointerClick(PointerEventData eventData)
    {
        if (MyIcon.raycastTarget == true)
        {
            HandScript.MyInstance.TakeMoveable(Myship as IMoveable);
            HandScript.MyInstance.ShipType = this.GetComponentInChildren<Ships>().ShipType;
            HandScript.MyInstance.ShipPart = this.GetComponentInChildren<Ships>().Space;
            AllSlotsScript.MyInstance.FromSlot = this;

            if (localGameManager.MyInstance.PlayerTurn == 1)
            {
                activeplayfieldindex = 0;
            }
            else
            {
                activeplayfieldindex = 1;
            }

            if (activeplayfieldindex == 0)
            {
                switch (HandScript.MyInstance.ShipType)
                {
                    case ShipType.AircraftCarrier:
                        AC1();
                        break;
                    case ShipType.BattleShip:
                        BS1();
                        break;
                    case ShipType.Submarine:
                        Sub1();
                        break;
                    case ShipType.Cruiser:
                        Cru1();
                        break;
                    case ShipType.Destroyer:
                        Des1();
                        break;
                }
            }
            else
            {
                switch (HandScript.MyInstance.ShipType)
                {
                    case ShipType.AircraftCarrier:
                        AC2();
                        break;
                    case ShipType.BattleShip:
                        BS2();
                        break;
                    case ShipType.Submarine:
                        Sub2();
                        break;
                    case ShipType.Cruiser:
                        Cru2();
                        break;
                    case ShipType.Destroyer:
                        Des2();
                        break;
                }
            }
        }
    }

    //these lines of code check if you can place your ship on the places that they want to be assigned to
    #region shipscheck
    public void AC1()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 60; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 0; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 6; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 16; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 26; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 36; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 46; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 56; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 66; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 76; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 86; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 96; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 7; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 8; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 0; i < 4; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 14; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 24; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 34; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 44; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 54; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 64; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 74; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 84; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 94; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 90; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 60; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 14; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 24; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 34; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 44; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 54; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 64; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 74; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 84; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 94; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 8; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 7; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 6; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 16; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 26; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 36; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 46; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 56; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 66; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 76; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 86; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 96; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void BS1()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 70; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 7; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 8; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 90; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 7; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 6; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 16; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 26; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 36; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 46; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 56; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 66; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 76; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 86; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 96; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void Sub1()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 8; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 99; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 10; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 1; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 7; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void Cru1()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 8; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 99; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 10; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 1; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 7; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void Des1()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[09].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[19].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[29].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[39].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[49].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[59].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[69].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[79].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[89].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[10].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[20].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[30].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[40].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[50].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[60].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[70].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[80].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[90].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[10].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[20].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[30].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[40].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[50].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[60].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[70].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[80].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[90].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[09].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[19].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[29].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[39].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[49].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[59].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[69].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[79].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[89].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots1[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
    }


    public void AC2()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 60; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 0; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 6; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 16; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 26; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 36; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 46; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 56; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 66; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 76; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 86; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 96; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 7; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 8; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 0; i < 4; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 14; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 24; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 34; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 44; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 54; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 64; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 74; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 84; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 94; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 90; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 60; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 14; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 24; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 34; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 44; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 54; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 64; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 74; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 84; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 94; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 8; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 7; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 5)
            {
                for (int i = 6; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 16; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 26; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 36; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 46; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 56; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 66; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 76; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 86; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 96; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void BS2()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 70; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 7; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 8; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 90; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 13; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 23; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 33; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 43; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 53; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 63; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 73; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 83; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 93; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 7; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 4)
            {
                for (int i = 6; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 16; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 26; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 36; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 46; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 56; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 66; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 76; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 86; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 96; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void Sub2()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 8; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 99; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 10; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 1; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 7; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void Cru2()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 80; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 8; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 18; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 28; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 38; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 48; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 58; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 68; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 78; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 88; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 98; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 99; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 10; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 80; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 0; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 70; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 2; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 10; i < 12; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 20; i < 22; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 30; i < 32; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 40; i < 42; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 50; i < 52; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 60; i < 62; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 70; i < 72; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 80; i < 82; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 90; i < 92; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 1; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 9; i < 11; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 19; i < 21; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 29; i < 31; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 39; i < 41; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 49; i < 51; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 59; i < 61; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 69; i < 71; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 79; i < 81; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 89; i < 91; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 3)
            {
                for (int i = 7; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 17; i < 20; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 27; i < 30; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 37; i < 40; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 47; i < 50; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 57; i < 60; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 67; i < 70; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 77; i < 80; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 87; i < 90; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
                for (int i = 97; i < 100; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
    }

    public void Des2()
    {
        for (int i = 0; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
        {
            AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = true;
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.sprite != SpriteName)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        if (HandScript.MyInstance.PartRotation.z == 0)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 90)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[09].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[19].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[29].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[39].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[49].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[59].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[69].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[79].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[89].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[10].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[20].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[30].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[40].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[50].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[60].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[70].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[80].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[90].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 180)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                for (int i = 90; i < AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2.Count; i++)
                {
                    AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[i].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                }
            }
        }
        else if (HandScript.MyInstance.PartRotation.z == 270)
        {
            if (HandScript.MyInstance.ShipPart == 1)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[0].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[10].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[20].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[30].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[40].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[50].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[60].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[70].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[80].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[90].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
            if (HandScript.MyInstance.ShipPart == 2)
            {
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[09].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[19].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[29].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[39].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[49].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[59].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[69].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[79].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[89].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
                AllPlayFieldsScript.MyInstance.MyPlayfield[activeplayfieldindex].GetComponent<MainPlayFieldScript>().Playslots2[99].GetComponent<MainPlayFieldSlotScript>().MyIcon.raycastTarget = false;
            }
        }
    }
    #endregion
}
