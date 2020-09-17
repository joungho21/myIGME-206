using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int score;
    public int nFood;
    public int level;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        nFood = 10;
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
