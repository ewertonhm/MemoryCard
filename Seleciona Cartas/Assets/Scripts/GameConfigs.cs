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

    void Awake()
    {
        instance = this;
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
}
