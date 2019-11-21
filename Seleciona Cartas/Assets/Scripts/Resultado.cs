using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Resultado : MonoBehaviour
{
    [SerializeField] GameObject textFieldTempo;
    [SerializeField] GameObject textFieldAcertos;
    [SerializeField] private int acertos;
    [SerializeField] private int numeroDeCartas;
    [SerializeField] private int pontos;
    [SerializeField] private int[] cartasSorteadas;
    [SerializeField] private int[] naipesSorteados;
    [SerializeField] private int[] cartasSelecionadas;
    [SerializeField] private int[] naipesSelecionados;
    
    public void calculaAcertos()
    {
        Ranking ranking = new Ranking();

        this.numeroDeCartas = GameConfigs.instance.getNumberOfCards();
        this.cartasSorteadas = GameConfigs.instance.getCartasValor();
        this.naipesSorteados = GameConfigs.instance.getCartasNaipe();
        this.cartasSelecionadas = GameConfigs.instance.getCartasSelecionadasValor();
        this.naipesSelecionados = GameConfigs.instance.getCartasSelecionadasNaipes();

        for(int c = 0; c<this.numeroDeCartas; c++)
        {
            Debug.Log("Carta Sorteada:" + this.cartasSorteadas[c]);
            Debug.Log("Carta Selecionada:" + this.cartasSelecionadas[c]);
            Debug.Log("Naipe Sorteada:" + this.naipesSorteados[c]);
            Debug.Log("Naipe Selecionada:" + this.naipesSelecionados[c]);
            if (this.cartasSorteadas[c] == this.cartasSelecionadas[c])
            {
                if(this.naipesSorteados[c] == this.naipesSelecionados[c])
                {
                    Debug.Log("Acerto");
                    this.acertos++;
                } else
                {
                    Debug.Log("Naipes não são iguais!");
                }
            } else
            {
                Debug.Log("Cartas não são iguais!");
            }
        }
        GameConfigs.instance.setAcertos(this.acertos);
        this.calcularPontos();
    }

    public void calcularPontos()
    {
        if(GameConfigs.instance.getGameTime() == 35)
        {
            this.pontos = this.acertos * 20;
        } else if(GameConfigs.instance.getGameTime() == 60)
        {
            this.pontos = this.acertos * 10;
        } else if(GameConfigs.instance.getGameTime() == 120)
        {
            this.pontos = this.acertos * 5;
        }
        GameConfigs.instance.setPontos(this.pontos);
        
    }

    public void salvaRanking()
    {
        GetComponent<Ranking>().lerDados();
        GetComponent<Ranking>().guardarPlayerPrefsNome();
        GetComponent<Ranking>().guardarPlayerPrefsAcertos();
        GetComponent<Ranking>().guardarPlayerPrefsNumeroDeCartas();
        GetComponent<Ranking>().guardarPlayerPrefsTempo();
        GetComponent<Ranking>().guardarPlayerPrefsPontos();
        PlayerPrefs.Save();
        //PlayerPrefs.DeleteAll();
    }

    void Start()
    {
        this.textFieldTempo.GetComponent<TextMeshProUGUI>().text = GameConfigs.instance.getGameTime().ToString();
        this.calculaAcertos();
        this.textFieldAcertos.GetComponent<TextMeshProUGUI>().text = this.acertos.ToString();
        this.salvaRanking();
    }
}
