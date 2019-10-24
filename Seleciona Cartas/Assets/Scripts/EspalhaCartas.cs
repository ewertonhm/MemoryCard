using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspalhaCartas : MonoBehaviour
{
    [SerializeField] int numberOfCards;
    [SerializeField] int[] sorteadaValor = new int[15];
    [SerializeField] int[] sorteadaNaipe = new int[15];
    public GameObject[] prefabCartas;


    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject carta in prefabCartas)
        {
            carta.SetActive(false);
        }
        this.numberOfCards = GameConfigs.instance.getNumberOfCards();
        this.sorteadaValor = new int[numberOfCards];
        this.sorteadaNaipe = new int[numberOfCards];

        for(int c = 0; c<this.numberOfCards; c++)
        {
            this.sorteadaValor[c] = Random.Range(0, 13);
            this.sorteadaNaipe[c] = Random.Range(0, 4);               
        }

        this.desrepetidorDeCartas();

        for(int c = 0; c < this.numberOfCards; c++)
        {
            prefabCartas[c].GetComponent<Carta>().setValor(this.sorteadaValor[c]);
            prefabCartas[c].GetComponent<Carta>().setNaipe(this.sorteadaNaipe[c]);
            prefabCartas[c].GetComponent<Carta>().updateSprite();
            prefabCartas[c].SetActive(true);
        }
        GameConfigs.instance.setCartasValor(this.sorteadaValor);
        GameConfigs.instance.setCartasNaipe(this.sorteadaNaipe);
    }
    public void desrepetidorDeCartas()
    {
        //Debug.Log("Chamou a Função");
        for(int c = 0; c<this.numberOfCards; c++)
        {
            for(int x = 0; x<this.numberOfCards; x++)
            {
                if(this.sorteadaValor[c] == this.sorteadaValor[x] && c != x)
                {
                    if(this.sorteadaNaipe[c] == this.sorteadaNaipe[x])
                    {
                        this.sorteadaValor[x] = Random.Range(0, 13);
                        this.sorteadaNaipe[x] = Random.Range(0, 4);
                        this.desrepetidorDeCartas();
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
