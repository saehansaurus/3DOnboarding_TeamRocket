using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour
{
    public GameManager gameManager;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            gameManager.GenPlayerStickmans(gameManager.stickmanCount, transform.position);
            gameObject.SetActive(false);
        }
    }
}
