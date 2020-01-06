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

    private List<GameObject> playslots = new List<GameObject>();

    public List<GameObject> Playslots { get => playslots; set => playslots = value; }


    // Start is called before the first frame update
    void Start()
    {
        var comparer = new PlayFieldSlotComparerscript();

        for (int i = 0; i < 100; i++)
        {
            GameObject tmp = FindObjectsOfType<MainPlayFieldSlotScript>()[i].gameObject;
            Playslots.Add(tmp);
        }
        Playslots.Sort(comparer);
    }
}
