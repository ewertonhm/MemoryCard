using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class ArrayLayout
{
    [System.Serializable]
    public struct rowData
    {
        public Image[] sprite;
    }

    public rowData[] rows = new rowData[4];
}
