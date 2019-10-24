using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
