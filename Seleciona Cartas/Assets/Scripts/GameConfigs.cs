using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfigs : MonoBehaviour
{
    public static GameConfigs instance;
    [SerializeField] int gameTime;
    [SerializeField] int numberOfCards;
    [SerializeField] int[] cartasValor;
    [SerializeField] int[] cartasNaipe;
    [SerializeField] int[] cartasSelecionadasValor;
    [SerializeField] int[] cartasSelecionadasNaipe;
    [SerializeField] int tempoRestante = 0;

    void Awake()
    {
        instance = this;
    }

    public void restartConfigs()
    {
        this.gameTime = 30;
        this.numberOfCards = 5;
        this.tempoRestante = 0;
        this.cartasValor = null;
        this.cartasNaipe = null;
        this.cartasSelecionadasValor = null;
        this.cartasSelecionadasNaipe = null;
    }

    public int getGameTime()
    {
        return this.gameTime;
    }
    public void setGameTime(int time)
    {
        this.gameTime = time;
    }
    public void setNumberOfCards(int cards)
    {
        this.numberOfCards = cards;
    }
    public int getNumberOfCards()
    {
        return this.numberOfCards;
    }
    public void setCartasValor(int[] value)
    {
        this.cartasValor = value;
    }
    public void setCartasNaipe(int[] value)
    {
        this.cartasNaipe = value;
    }
    public int[] getCartasValor()
    {
        return this.cartasValor;
    }
    public int[] getCartasNaipe()
    {
        return this.cartasNaipe;
    }
    public void adicionarTempoRestante(int tempo)
    {
        this.tempoRestante += tempo;
    }
    public void setTempoRestante(int tempo)
    {
        this.tempoRestante = tempo;
    }
    public int getTempoRestante()
    {
        return this.tempoRestante;
    }
    public void setCartasSelecionadasValor(int[] cartas)
    {
        this.cartasSelecionadasValor = cartas;
    }
    public int[] getCartasSelecionadasValor()
    {
        return this.cartasSelecionadasValor;
    }
    public void setCartasSelecionadasNaipe(int[] naipes)
    {
        this.cartasSelecionadasNaipe = naipes;
    }
    public int[] getCartasSelecionadasNaipes()
    {
        return this.cartasSelecionadasNaipe;
    }
}
