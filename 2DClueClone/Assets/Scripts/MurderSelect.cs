using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// private class Murderer {
    
//     private string name;
//     private string[] weapons = new string[4];
//     private string description;

//     // Constructor
//     public Muderer(int scl) {
//         switch (scl) {
//             case 1:
//                 name = "Chef";
//                 weapons = ["Knife", "Dirty Jacket", "Cigarette Butt", "Beer Bottle"];
//                 break;
//             case 2:
//                 break;
//             case 3:
//                 break;
//             case 4:
//                 break;
//             case 5:
//                 break;
//             case 6:
//                 break;
//             default:
//             break;
//         }
//     }
// }

public class MurderSelect : MonoBehaviour {
    /*
    * So my plan for now was to make an array of the muderer's names as strings, then announce
    * using an event to the items that will listen. When the items hear the right name, they'll be
    * changed to bloodied to help the player figure out who is the murderer
    *
    * Option 2: Read and write to a file and keep all the character data in some text file
    * Option 3: Creating a list of objects and reference said list.
    */

    private string[] murderers = {"Chef", "House Maid", "Gardener", "Pirate", "Butler", "Pool Boy"};
    public string killer = "";

    // Start is called before the first frame update
    void Start() {
        killer = murderers[0];
    }

    // Update is called once per frame
    void Update() {}
}
