using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public int score;
    
    private float time = 2;
    private int level = 5;

    public Rigidbody itemPrefab;
    public Transform spawn;

    private void Start()
    {
        //score = GetComponent<ScoreManager>().IntScore;

    }


    private void Update()
    {

    }
}
