using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllPlayFieldsScript : MonoBehaviour
{

    private static AllPlayFieldsScript instance;

    public static AllPlayFieldsScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AllPlayFieldsScript>();
            }

            return instance;
        }
    }

    [SerializeField]
    private GameObject[] playfield;

    public GameObject[] MyPlayfield { get => playfield; set => playfield = value; }
}
