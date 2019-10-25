using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Carta : MonoBehaviour
{
    [SerializeField] int valor;
    [SerializeField] int naipe;
    public CardArrayLayout Sprites;

    public void setValor(int v)
    {
        this.valor = v;
    }

    public int getValor()
    {
        return this.valor;
    }

    public void setNaipe(int n)
    {
        this.naipe = n;
    }
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Image>().sprite = Sprites.numero[this.valor].naipe[this.naipe];
    }
    public void updateSprite()
    {
        GetComponent<Image>().sprite = Sprites.numero[this.valor].naipe[this.naipe];
    }
    public void addValor()
    {
        if(this.valor <= 11)
        {
            this.valor++;
        } else
        {
            this.valor = 0;
        }
        this.updateSprite();
    }
    public void subValor()
    {
        if(this.valor >= 1)
        {
            this.valor--;
        } else
        {
            this.valor = 12;
        }
        this.updateSprite();
    }
    public void addNaipe()
    {
        if(this.naipe <= 2)
        {
            this.naipe++;
        } else
        {
            this.naipe = 0;
        }
        this.updateSprite();
    }
    public void subNaipe()
    {
        if(this.naipe >= 1)
        {
            this.naipe--;
        } else
        {
            this.naipe = 3;
        }
        this.updateSprite();
    }
    public void selectCard(int p)
    {
        GameConfigs.instance.setCartaAtual(p);
        SceneManager.LoadScene("CardValueSelectScreen");
    }
    public void save()
    {
        Debug.Log("Salvando carta na posicao: " + GameConfigs.instance.getCartaAtual() + " Com o Valor: " + this.valor + " e naipe: " + this.naipe);
        GameConfigs.instance.setCartaSelecionadaValor(GameConfigs.instance.getCartaAtual(), this.valor);
        GameConfigs.instance.setCartaSelecionadaNaipe(GameConfigs.instance.getCartaAtual(), this.naipe);
        GameConfigs.instance.setCartaSelecionada(GameConfigs.instance.getCartaAtual(), true);
        this.returnToCardSelectScreen();
    }
    public void returnToCardSelectScreen()
    {
        SceneManager.LoadScene("CardSelectScreen");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
