using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    
    [SerializeField] float currentSpeed = 1f;
    
    void Update() {
        WalkLeftDirection();
    }

    public void SetMovementSpeed(float newSpeed) {
        currentSpeed = newSpeed;
    }

    private void WalkLeftDirection() {
        transform.Translate(Vector2.left * currentSpeed * Time.deltaTime);
    }
}