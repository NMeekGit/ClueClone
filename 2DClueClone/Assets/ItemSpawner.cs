using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] items;
    public GameObject[] bloodItems;
    
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

        BloodyItems(murderManager.GetMuderer());

        foreach(int i in usedNums) {
            int temp = i;
            Instantiate(items[temp], spawnpoints[count].position, Quaternion.identity);
            count++;
        }

        //items[murderManager.GetCharacterItems(1)].sprite = bloodySprites[1];
        
    }

    void UniqueNums() {
        ranNum = Random.Range(0, items.Length);
        if(!usedNums.Contains(ranNum))
            usedNums.Add(ranNum);
    }

    public void BloodyItems(string name) {
        //Debug.Log("Place holder text: " + name);
        items[murderManager.GetCharacterItems(name, 0)] = bloodItems[murderManager.GetCharacterItems(name, 0)];
        items[murderManager.GetCharacterItems(name, 1)] = bloodItems[murderManager.GetCharacterItems(name, 1)];
        items[murderManager.GetCharacterItems(name, 2)] = bloodItems[murderManager.GetCharacterItems(name, 2)];
        items[murderManager.GetCharacterItems(name, 3)] = bloodItems[murderManager.GetCharacterItems(name, 3)];
    }
}
