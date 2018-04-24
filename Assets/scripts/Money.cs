using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour {

    public static int moneyVal;

    void Start()
    {
        moneyVal = 500; //starting money
    }

    void Update () {
		if(moneyVal < 0)
        {
            //bankrupt game over
        }
	}
}
