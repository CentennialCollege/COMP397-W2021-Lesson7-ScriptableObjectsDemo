using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum KeyType
{
    KEY,
    ARROW,
    NUMPAD
}

[System.Serializable]
public class KeyOption
{
    public string name;
    public int value;
}


[CreateAssetMenu(fileName = "MovementOptions", menuName = "OptionsMenu/MovementOptions")]
public class MovementOptionsSO : ScriptableObject
{
    public KeyOption upKey;
    public KeyOption downKey;
    public KeyOption rightKey;
    public KeyOption leftkey;
}
