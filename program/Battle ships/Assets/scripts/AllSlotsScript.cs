using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSlotsScript : MonoBehaviour
{
    private static AllSlotsScript instance;

    public static AllSlotsScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<AllSlotsScript>();
            }

            return instance;
        }
    }

    private SlotScript fromSlot;

    [SerializeField]
    private GameObject[] fullship;

    [SerializeField]
    private int spacesNeeded;
    
    public SlotScript FromSlot
    {
        get
        {
            return fromSlot;
        }

        set
        {
            fromSlot = value;
        }
    }

    public GameObject[] MyFullship { get => fullship; set => fullship = value; }
    public int MySpacesNeeded { get => spacesNeeded; set => spacesNeeded = value; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
