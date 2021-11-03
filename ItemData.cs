using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[System.Serializable]
public class ItemData
{
    public int FaceMask;
    public int Goggles;
    public int FaceShield;

    public ItemData (Items items)
    {
        FaceMask = items.FaceMask;
        Goggles = items.Goggles;
        FaceShield = items.FaceShield;
    }
}
