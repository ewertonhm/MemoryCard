using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoBehaviour
{
    public string theName;
    [SerializeField] public GameObject inputField;

    public void storeName()
    {
        theName = inputField.GetComponentInChildren<Text>().text;
        GameConfigs.instance.setNome(theName);
    }
}
