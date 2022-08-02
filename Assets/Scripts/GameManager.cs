using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject PlayerStickmanPrefab;
    private Stack<GameObject> playerStickmanPool = new Stack<GameObject>();
    public int stickmanCount;
    public GameObject PlayerObject;
    
    void Start()
    {
        stickmanCount = 1;
        for (int i = 0; i < 100; i++) {
            var stickmanObj = Instantiate(PlayerStickmanPrefab, new Vector3(0, -100f, 0), Quaternion.identity);
            stickmanObj.SetActive(false);
            playerStickmanPool.Push(stickmanObj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenPlayerStickmans(int count, Vector3 location) {
        for (int i = 0; i < count; i++) {
            Debug.Log(count);
            var stickman = playerStickmanPool.Pop();
            stickman.SetActive(true);
            stickman.transform.position = new Vector3(location.x, 0.52f, location.z);
            stickman.transform.SetParent(PlayerObject.transform);
            stickmanCount++;
        }
    }

    public void KillPlayerStickman(GameObject stickmanObj) {
        stickmanObj.transform.SetParent(null);
        stickmanObj.SetActive(false);
        playerStickmanPool.Push(stickmanObj);
    }
}
