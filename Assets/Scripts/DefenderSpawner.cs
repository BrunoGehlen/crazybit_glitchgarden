using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    [SerializeField] float offSetY = -0.4f, offSetX = 0f;
    
    private void OnMouseDown()
    {
        SpawnDefender(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
        
    }

    private Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);

        return new Vector2(newX + offSetX, newY + offSetY);
    }
    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }
    private void SpawnDefender(Vector2 roundedPos)
    {
        
        Defender newDefender = 
            Instantiate(
                defender, 
                roundedPos, 
                Quaternion.identity) as Defender;
        
        FindObjectOfType<StarDisplay>().AddStar(-defender.starCost);
        //GetComponent<StarDisplay>().UpdateStar(-defender.starCost);
    }
}
