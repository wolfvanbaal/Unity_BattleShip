using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContainerScript : MonoBehaviour
{
    private static ContainerScript instance;

    public static ContainerScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ContainerScript>();
            }

            return instance;
        }
    }

    [SerializeField]
    private AllSlotsScript[] allSlotsScripts;

    public AllSlotsScript[] MyAllSlotsScripts { get => allSlotsScripts; set => allSlotsScripts = value; }
}
