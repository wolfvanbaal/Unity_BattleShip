using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayFieldScript : MonoBehaviour
{
    private static MainPlayFieldScript instance;

    public static MainPlayFieldScript MyInstance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<MainPlayFieldScript>();
            }

            return instance;
        }
    }

    private List<GameObject> playslots1 = new List<GameObject>();

    private List<GameObject> playslots2 = new List<GameObject>();

    public List<GameObject> Playslots1 { get => playslots1; set => playslots1 = value; }

    public List<GameObject> Playslots2 { get => playslots2; set => playslots2 = value; }

    public bool player2turn = false;

    // Start is called before the first frame update
    void Start()
    {
        var comparer = new PlayFieldSlotComparerscript();

        for (int i = 0; i < 100; i++)
        {
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponentsInChildren<MainPlayFieldSlotScript>()[i].MyParent.name == "MainPlayFieldPlayer1")
            {
                GameObject tmp = AllPlayFieldsScript.MyInstance.MyPlayfield[0].GetComponentsInChildren<MainPlayFieldSlotScript>()[i].gameObject;
                Playslots1.Add(tmp);
            }
        }
        Playslots1.Sort(comparer);
        for (int i = 0; i < 100; i++)
        {
            if (AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponentsInChildren<MainPlayFieldSlotScript>()[i].MyParent.name == "MainPlayFieldPlayer2")
            {
                GameObject tmp = AllPlayFieldsScript.MyInstance.MyPlayfield[1].GetComponentsInChildren<MainPlayFieldSlotScript>()[i].gameObject;
                Playslots2.Add(tmp);
            }
        }
        Playslots2.Sort(comparer);
    }
}
