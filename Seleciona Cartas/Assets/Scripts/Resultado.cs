using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Resultado : MonoBehaviour
{
    [SerializeField] GameObject textFieldTempo;
    [SerializeField] GameObject textFieldAcertos;
    [SerializeField] private int Acertos = 0;
    private int numeroDeCartas;
    private int[] cartasSorteadas;
    private int[] naipesSorteados;
    private int[] cartasSelecionadas;
    private int[] naipesSelecionados;
    
    public void calculaAcertos()
    {
        this.numeroDeCartas = GameConfigs.instance.getNumberOfCards();
        this.cartasSorteadas = GameConfigs.instance.getCartasValor();
        this.naipesSorteados = GameConfigs.instance.getCartasNaipe();
        this.cartasSelecionadas = GameConfigs.instance.getCartasSelecionadasValor();
        this.naipesSelecionados = GameConfigs.instance.getCartasSelecionadasNaipes();

        for(int c = 0; c<=this.numeroDeCartas; c++)
        {
            if(this.cartasSorteadas[c] == this.cartasSelecionadas[c])
            {
                if(this.naipesSorteados[c] == this.naipesSelecionados[c])
                {
                    this.Acertos++;
                }
            }
        }
    }

    void Start()
    {
        this.textFieldTempo.GetComponent<TextMeshProUGUI>().text = GameConfigs.instance.getTempoRestante().ToString();
        this.calculaAcertos();
        this.textFieldAcertos.GetComponent<TextMeshProUGUI>().text = this.Acertos.ToString();
    }
}
