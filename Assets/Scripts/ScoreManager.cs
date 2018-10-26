using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {
    
    public Text TextScore;
    private int IntScore;
    

    private void OnCollisionEnter(Collision Item)
    {
        if ((Item.gameObject.tag == "Ingrediant"))
        {
            IntScore += 100;
            TextScore.text = IntScore.ToString();
        }
    }
}

