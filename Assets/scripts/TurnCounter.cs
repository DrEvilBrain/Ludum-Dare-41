using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnCounter : MonoBehaviour {

    public Button turnEnd;
    public Text turnCount;
    private int turnNum;

	void Start (){
        turnNum = 1;
        turnEnd.onClick.AddListener(EndTurn);
    }
	
	void EndTurn(){
        turnNum++;
        turnCount.text = "Turn " + turnNum;
    }
}
