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

    public Ships Myship
    {
        get
        {
            return GetComponentInChildren<Ships>();
        }
    }

    public Image MyIcon { get => icon; }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (MyIcon.enabled == true)
        {
            HandScript.MyInstance.TakeMoveable(Myship as IMoveable);
            HandScript.MyInstance.ShipType = this.GetComponentInChildren<Ships>().ShipType;
            HandScript.MyInstance.ShipPart = this.GetComponentInChildren<Ships>().Space;
            AllSlotsScript.MyInstance.FromSlot = this;
        }
    }
}
