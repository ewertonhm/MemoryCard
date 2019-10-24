using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSelect : MonoBehaviour
{
    [SerializeField] GameObject[] cartas;
    private int numberOfCards;
    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject carta in cartas)
        {
            carta.SetActive(false);
        }
        this.numberOfCards = GameConfigs.instance.getNumberOfCards();
        for(int c = 0 ; c<numberOfCards ; c++)
        {
            cartas[c].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
