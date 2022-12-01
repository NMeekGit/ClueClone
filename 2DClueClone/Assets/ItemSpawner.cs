using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] items;
    public Transform[] spawnpoints;
    
    private List<int> usedNums = new List<int>();
    private int ranNum;
    
    // Start is called before the first frame update
    void Start()
    {
        /*for(int i = 0; i < items[].Length; i++) {
            UniqueNums();
        }
        
        foreach(int i in usedNums) {
            Instantiate(items[i], spawnpoints[i]);
        }
        for(int i = 0; i < spawnpoints.Length; i++) {
            Instantiate(items[usedNums[i]], spawnpoints[i]);
        }

        */
    }

    void UniqueNums() {
        ranNum = Random.Range(0, items.Length);
        if(!usedNums.Contains(ranNum))
            usedNums.Add(ranNum);
    }
}
