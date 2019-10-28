using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ranking : MonoBehaviour
{
    [SerializeField] List<string> nome = new List<string>();
    [SerializeField] List<int> acertos = new List<int>();
    [SerializeField] int[] numeroDeCartas;
    [SerializeField] int[] tempo;


    public string getNome(int posicao)
    {
        return this.nome[posicao];
    }
    public int getAcerto(int posicao)
    {
        return this.acertos[posicao];
    }
    public int getNumeroDeCartas(int posicao)
    {
        return this.numeroDeCartas[posicao];
    }
    public int getTempo(int posicao)
    {
        return this.tempo[posicao];
    }

    public void setNome(int posicao, string nome)
    {
        this.nome.Add(nome);
    }
    public void setAcertos(int acertos)
    {
        this.acertos.Add(acertos);
    }
    public void setNumeroDeCartas(int posicao, int numeroDeCartas)
    {
        this.numeroDeCartas[posicao] = numeroDeCartas;
    }
    public void setTempo(int posicao, int tempo)
    {
        this.tempo[posicao] = tempo;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
