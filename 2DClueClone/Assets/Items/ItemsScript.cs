using UnityEngine;

public abstract class ItemsScript : ScriptableObject
{
    public abstract void Open(GameObject target);
    public abstract void Close(GameObject target);
}
