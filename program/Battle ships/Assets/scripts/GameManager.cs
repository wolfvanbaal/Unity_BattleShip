using Firebase;
using Firebase.Analytics;
using Firebase.Database;
using Firebase.Unity.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject sprite;

    public DatabaseReference reference;

    // Start is called before the first frame update
    void Start()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWith(continuationAction: task =>
        {
             FirebaseAnalytics.SetAnalyticsCollectionEnabled(true);
        });
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void clicked()
    {
        Refrence();

        Ships ship = new Ships(sprite);
        
        string json = JsonUtility.ToJson(ship);

        reference.Child("test2").SetValueAsync(json);
    }

    public void retrive()
    {
        Refrence();

        FirebaseDatabase.DefaultInstance
        .GetReference("test2")
        .GetValueAsync().ContinueWith(task => 
        {
            if (task.IsFaulted)
            {
                  // Handle the error...
            }
            else if (task.IsCompleted)
            {
                DataSnapshot snapshot = task.Result;
            }
        });
    }

    public void Refrence ()
    {
        // Set this before calling into the realtime database.
        FirebaseApp.DefaultInstance.SetEditorDatabaseUrl("https://battle-ships-683ab.firebaseio.com/");

        // Get the root reference location of the database.
        reference = FirebaseDatabase.DefaultInstance.RootReference;
    }
}
