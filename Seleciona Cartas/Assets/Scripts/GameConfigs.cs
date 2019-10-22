using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConfigs : MonoBehaviour
{
    
    public static GameConfigs instance;
    [SerializeField] int gameTime;
    [SerializeField] int numberOfCards;
    [SerializeField] string[] cartas;

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
    public void setCartas(string[] c)
    {
        this.cartas = c;
    }

}
