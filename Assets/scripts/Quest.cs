using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {

    public static int numScore;
    public static int numMoneyGained;
    public static int numTurnsLeft;

    public static bool endQuest;

    public static string[] photoOrderText = new string[10];

    void Start()
    {
        endQuest = false;
    }

    void Update()
    {
        if(numTurnsLeft == 0 || endQuest == true) //end of quest
        {
            endQuest = false;

            
        }
    }

}
