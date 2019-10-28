using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardSelect : MonoBehaviour
{
    [SerializeField] GameObject[] cartas;
    [SerializeField] Sprite verso;
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
            if (GameConfigs.instance.getCartaSelecionada(c) == true)
            {
                cartas[c].GetComponent<Carta>().setValor(GameConfigs.instance.getCartaSelecionadaValor(c));
                cartas[c].GetComponent<Carta>().setNaipe(GameConfigs.instance.getCartaSelecionadaNaipe(c));
                cartas[c].GetComponent<Carta>().updateSprite();
            } else
            {
                cartas[c].GetComponent<Image>().sprite = verso;
            }
            cartas[c].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
