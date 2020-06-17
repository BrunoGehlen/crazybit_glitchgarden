using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSelection : MonoBehaviour
{
    private void OnMouseDown()
    {
        var buttons = FindObjectsOfType<DefenderSelection>();
        foreach (DefenderSelection button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(255, 255, 255, 125);
        }

        GetComponent<SpriteRenderer>().color = Color.white;

    }
}
