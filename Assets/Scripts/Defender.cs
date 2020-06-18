using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] public int starCost = 15;

    // only trophy
    private void TrophyCoinReward()
    {
        FindObjectOfType<StarDisplay>().AddStar(10);
    }

}
