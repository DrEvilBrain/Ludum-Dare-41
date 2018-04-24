using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestUI : MonoBehaviour {

    public Button turnEnd;
    public Button questEnd;

    public Text score;
    public Text moneyGained;
    public Text photoOrder;
    public Text turnsLeft;

    private string[] photoOrderText = new string[10];

    void Start(){
        turnEnd.onClick.AddListener(EndTurn);
        turnEnd.onClick.AddListener(QuestEnd);
    }

    void Update (){
		
	}

    void EndTurn(){
        Quest.numTurnsLeft--;
    }

    void QuestEnd()
    {
        Quest.endQuest = true;
    }
  
}
