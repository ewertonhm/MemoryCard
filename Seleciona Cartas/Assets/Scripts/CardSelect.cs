using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSelect : MonoBehaviour
{
    [SerializeField] GameObject[] cartas;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject carta in cartas)
        {
            carta.SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
