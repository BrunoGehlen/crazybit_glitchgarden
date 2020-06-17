using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] public int starCost = 15;

    private void TrophyCoinReward()
    {
        FindObjectOfType<StarDisplay>().AddStar(10);
    }

}
