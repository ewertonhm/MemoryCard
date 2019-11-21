using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ranking : MonoBehaviour
{
    [SerializeField] List<string> nome = new List<string>();
    [SerializeField] List<int> acertos = new List<int>();
    [SerializeField] List<int> numeroDeCartas = new List<int>();
    [SerializeField] List<int> tempo = new List<int>();


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

    public void setNome(string nome)
    {
        this.nome.Add(nome);
    }
    public void setAcertos(int acertos)
    {
        this.acertos.Add(acertos);
    }
    public void setNumeroDeCartas(int numeroDeCartas)
    {
        this.numeroDeCartas.Add(numeroDeCartas);
    }
    public void setTempo(int tempo)
    {
        this.tempo.Add(tempo);
    }
    public void lerDados()
    {
        this.setAcertos(GameConfigs.instance.getAcertos());
        this.setNumeroDeCartas(GameConfigs.instance.getNumberOfCards());
        this.setNome("haru");
        this.setTempo(GameConfigs.instance.getGameTime());
    }
    public List<string> getListNome()
    {
        return this.nome;
    }
    public List<int> getListAcertos()
    {
        return this.acertos;
    }
    public List<int> getListNumerDeCartas()
    {
        return this.numeroDeCartas;
    }
    public List<int> getListTempo()
    {
        return this.tempo;
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
