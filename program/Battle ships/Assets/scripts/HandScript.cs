using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HandScript : MonoBehaviour
{
    private static HandScript instance;

    public static HandScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<HandScript>();
            }

            return instance;
        }
    }

    private Image icon;

    private Vector3 partRotation;

    private int shipPart;

    private ShipType shipType; 

    public IMoveable MyMoveable { get; set; }

    public Image MyIcon { get => icon; set => icon = value; }

    internal ShipType ShipType { get => shipType; set => shipType = value; }

    public int ShipPart { get => shipPart; set => shipPart = value; }

    public Vector3 PartRotation { get => partRotation; set => partRotation = value; }


    // Start is called before the first frame update
    void Start()
    {
        MyIcon = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        MyIcon.transform.position = Input.mousePosition;

        if (Input.GetMouseButtonDown(1))
        {
            MyIcon.rectTransform.Rotate(new Vector3(0, 0, 90));
            PartRotation += new Vector3(0, 0, 90);
            if (partRotation.z == 360)
            {
                partRotation.z = 0;
            }
            switch (ShipType)
            {
                case ShipType.AircraftCarrier:
                    SlotScript.MyInstance.AC();
                    break;
                case ShipType.BattleShip:
                    SlotScript.MyInstance.BS();
                    break;
                case ShipType.Submarine:
                    SlotScript.MyInstance.Sub();
                    break;
                case ShipType.Cruiser:
                    SlotScript.MyInstance.Cru();
                    break;
                case ShipType.Destroyer:
                    SlotScript.MyInstance.Des();
                    break;
            }
        }
    }

    public void TakeMoveable(IMoveable moveable)
    {
        this.MyMoveable = moveable;
        MyIcon.sprite = moveable.MyIcon;
        MyIcon.enabled = true;
    }

    public IMoveable Put()
    {
        IMoveable tmp = MyMoveable;
        MyMoveable = null;
        MyIcon.enabled = false;
        return tmp;
    }

    public void Drop()
    {
        MyMoveable = null;
        MyIcon.enabled = false;
        AllSlotsScript.MyInstance.FromSlot.MyIcon.enabled = false;
        AllSlotsScript.MyInstance.FromSlot = null;
    }
}
