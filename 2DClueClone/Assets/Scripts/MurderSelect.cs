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
    private Dictionary<string, int[]> killers = new Dictionary<string, int[]>();
    private string[] killersNames = {"Chef", "House Maid", "Gardener", "Pirate", "Butler", "Pool Boy"};
    private string killerDictionaryKey;
    private int[] killerItems;
    
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

        /* Item Indices (for alec)
        0 knife
        1 dirty apron
        2 cigarette butt
        3 beer bottle
        4 candlestick
        5 letter opener
        6 watch
        7 rope
        8 trowl
        9 chemicals*/

        int[] chefItems = {0, 1, 2, 3};
        int[] maidItems = {4, 5, 6, 7};
        int[] gardenerItems = {1, 7, 8, 9};
        int[] pirateItems = {2, 3, 7, 8};
        int[] butlerItems = {0, 4, 5, 6};
        int[] poolBoyItems = {6, 7, 8, 9};
        
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
     * @return int[]: returns an array of the indices for the items for the associated killer
     *      from the parameter
     */
    public int[] GetCharacterItems(string ch) {
        return killers[ch];
    }
    public int[] GetCharacterItems(int num) {
        return killers[killersNames[num]];
    }
    public int GetCharacterItems(string ch, int i) {
        int[] items = killers[ch];
        return items[i];
    }
    
}
