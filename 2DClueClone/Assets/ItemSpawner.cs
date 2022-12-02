using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] items;
    public Sprite[] bloodySprites;
    public Transform[] spawnpoints;

    public MurderSelect murderManager;
    
    private List<int> usedNums = new List<int>();
    private int ranNum;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        while(usedNums.Count < items.Length) {
            UniqueNums();
        }

        foreach(int i in usedNums) {
            int temp = i;
            Instantiate(items[temp], spawnpoints[count].position, Quaternion.identity);
            count++;
        }

        //Debug.Log("MurderSelect.GetCharacterItems(1): " + murderManager.GetMurderItems(1));
        //items[murderManager.GetCharacterItems(1)].sprite = bloodySprites[1];
        
    }

    void UniqueNums() {
        ranNum = Random.Range(0, items.Length);
        if(!usedNums.Contains(ranNum))
            usedNums.Add(ranNum);
    }
}
