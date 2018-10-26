using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    
    private SpriteRenderer sp;
    private SphereCollider sph;
    private bool collected = false;

    public Text TextScore;
    public int IntScore;


	// Use this for initialization
	void Start ()
    {
        sp = GetComponent<SpriteRenderer>();
        sph = GetComponent<SphereCollider>();
	}

    private void OnCollisionEnter(Collision Player)
    {
        if ((Player.gameObject.tag == "Player") && !collected)
        {
            sp.sortingLayerName = "Behind";
            collected = true;
            IntScore += 100;
            TextScore.text = IntScore.ToString();

            sp.enabled = false;
            sph.enabled = false;
        }
    }



    private void Update()
    {
        if (transform.position.y <= -9.0f)
        {
            collected = false;
            sp.sortingLayerName = "Default";
            
            sp.enabled = true;
            sph.enabled = true;
        }
    }
}

