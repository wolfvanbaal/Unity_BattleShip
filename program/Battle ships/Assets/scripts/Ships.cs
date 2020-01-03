using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ShipType {AircraftCarrier, BattleShip, Submarine, Cruiser, Destroyer }

public class Ships : MonoBehaviour, IMoveable
{
    [SerializeField]
    private ShipType shipType;

    [SerializeField]
    public Sprite sprite;
    
    public bool alive = true;

    [SerializeField]
    private int space;

    public Sprite MyIcon
    {
        get
        {
            return sprite;
        }
    }

    internal ShipType ShipType { get => shipType; }

    public int Space { get => space; set => space = value; }
}
