/* MurderSelect.cs
 * Author: Mateos Pereira
 * Date: 11/18/2022
 * Purpose: Selects a murderer and returns their giving items to determine whether or not
 *      they are the murderer or not. Built for Aztec Game Lab Workshop 3: Puzzle Game.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MurderSelect : MonoBehaviour {

    // Private Fields
    private Dictionary<string, string[]> killers = new Dictionary<string, string[]>();
    private string[] killersNames = {"Chef", "House Maid", "Gardener", "Pirate", "Butler", "Pool Boy"};
    private string killerDictionaryKey;
    private string[] killerItems;
    
    // Awakes when the game starts and selects a killer
    void Awake() {
        SetKiller(Random.Range(0,6));
    }

    /* SetKiller
     * @param int killVal: index of the name of the murderer, a random value between 0 and 5
     * @return string[] killerItems: a string array of the suspects items
     * 
     * The killerDictionaryKey is set to the name of the killer from the killer array above 
     * and selected by the parameter. Each of the string arrays below are the list of the
     * items, (yeah i know theres probably an easier way to do it, you fix it if you want it
     * fixed)
     * After, every entry is added to the dictionary with the name as the associated key so
     * the dictionary looks like this:
     * Chef - knife, dirty Apron, Cigarette butt, beer bottle
     * House maid - candlestick, letter opener, watch, rope
     * Gardener - garden tool, rope, dirty apron, Chemicals
     * Pirate - rope, beer bottle, Cigarette butt, garden tool
     * Butler - knife,  letter opener, watch, candlestick
     * Pool boy - Chemicals, rope, garden tool, watch
     * 
     */
    private void SetKiller(int killVal) {
        
        killerDictionaryKey = killersNames[killVal];

        string[] chefItems = {"Knife", "Dirty Apron", "Cigarette Butt", "Beer Bottle"};
        string[] maidItems = {"Candlestick", "Letter Opener", "Watch", "Rope"};
        string[] gardenerItems = {"Trowl", "Rope", "Dirty Apron", "Chemicals"};
        string[] pirateItems = {"Rope", "Beer Bottle", "Cigarette Butt", "Trowl"};
        string[] butlerItems = {"Knife", "Letter Opener", "Watch", "Candlestick"};
        string[] poolBoyItems = {"Chemicals", "Rope", "Trowl", "Watch"};
        
        killers.Add("Chef", chefItems);
        killers.Add("House Maid", maidItems);
        killers.Add("Gardener", gardenerItems);
        killers.Add("Pirate", pirateItems);
        killers.Add("Butler", butlerItems);
        killers.Add("Pool Boy", poolBoyItems);
        
        killerItems = killers[killerDictionaryKey];
    }

    /* GetCharacterItems
     * @param string ch: the name of the killer whose items you want to get
     * @param int num: the index of the killer from killerNames whose items you
     *      want to get
     * @return string[]: returns an array of the items from the associated killer
     *      from the parameter
     */
    public string[] GetCharacterItems(string ch) {
        return killers[ch];
    }
    public string[] GetCharacterItems(int num) {
        return killers[killersNames[num]];
    }
    public string GetCharacterItems(string ch, int i) {
        string[] items = killers[ch];
        return items[i];
    }
    
}
