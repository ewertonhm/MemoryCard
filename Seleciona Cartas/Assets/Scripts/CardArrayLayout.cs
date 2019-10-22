using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class CardArrayLayout 
{
    [System.Serializable]
    public struct rowData
    {
        public Sprite[] naipe;
    }

    public rowData[] numero = new rowData[13];
}
