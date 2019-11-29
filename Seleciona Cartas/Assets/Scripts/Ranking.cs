using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ranking : MonoBehaviour
{
    [SerializeField] List<string> nome = new List<string>();
    [SerializeField] List<int> acertos = new List<int>();
    [SerializeField] List<int> numeroDeCartas = new List<int>();
    [SerializeField] List<int> tempo = new List<int>();
    [SerializeField] List<int> pontos = new List<int>();

    Dictionary<string, Dictionary<string, int>> playerScores;

    public int getPlayerScore(string username, string scoreType)
    {
        Init();

        if(playerScores.ContainsKey(username) == false)
        {
            // we have no score record at all for this username
            return 0;
        }
        if(playerScores[username].ContainsKey(scoreType) == false)
        {
            return 0;
        }

        return playerScores[username][scoreType];
    }

    public void SetPlayerScore(string username, string scoreType, int value)
    {
        Init();

        if (playerScores.ContainsKey(username) == false)
        {
            playerScores[username] = new Dictionary<string, int>();
        }

        playerScores[username][scoreType] = value;
    }

    public void ChangeScore(string username, string scoreType, int amount)
    {
        Init();
        int currScore = getPlayerScore(username, scoreType);
        SetPlayerScore(username, scoreType, currScore + amount);
    }

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
    public void setPontos(int pontos)
    {
        this.pontos.Add(pontos);
    }
    public void lerDados()
    {
        this.lerPlayerPrefsNome();
        this.lerPlayerPrefsNumeroDeCartas();
        this.lerPlayerPrefsAcertos();
        this.lerPlayerPrefsPontos();
        this.lerPlayerPrefsTempo();

        this.setAcertos(GameConfigs.instance.getAcertos());
        this.setNumeroDeCartas(GameConfigs.instance.getNumberOfCards());
        this.setPontos(GameConfigs.instance.getPontos());
        this.setNome(GameConfigs.instance.getNome());
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

    public void lerPlayerPrefsNome()
    {
        int c = 0;
        while(PlayerPrefs.GetString("nome"+c.ToString(), "fim") != "fim")
        {
            setNome(PlayerPrefs.GetString("nome" + c.ToString()));
            c++;
        }
    }
    public void guardarPlayerPrefsNome()
    {
        for(int i = 0; i<this.nome.Count; i++)
        {
            PlayerPrefs.SetString("nome" + i, this.nome[i]);
        }
    }
    public void lerPlayerPrefsAcertos()
    {
        int c = 0;
        while (PlayerPrefs.GetInt("acertos" + c.ToString(), 9999999) != 9999999)
        {
            setAcertos(PlayerPrefs.GetInt("acertos" + c.ToString()));
            c++;
        }
    }
    public void guardarPlayerPrefsAcertos()
    {
        for (int i = 0; i < this.acertos.Count; i++)
        {
            PlayerPrefs.SetInt("acetos" + i, this.acertos[i]);
        }
    }
    public void lerPlayerPrefsNumeroDeCartas()
    {
        int c = 0;
        while (PlayerPrefs.GetInt("NumeroDeCartas" + c.ToString(), 9999999) != 9999999)
        {
            setAcertos(PlayerPrefs.GetInt("NumeroDeCartas" + c.ToString()));
            c++;
        }
    }
    public void guardarPlayerPrefsNumeroDeCartas()
    {
        for (int i = 0; i < this.numeroDeCartas.Count; i++)
        {
            PlayerPrefs.SetInt("numeroDeCartas" + i, this.numeroDeCartas[i]);
        }
    }
    public void lerPlayerPrefsTempo()
    {
        int c = 0;
        while (PlayerPrefs.GetInt("tempo" + c.ToString(), 9999999) != 9999999)
        {
            setAcertos(PlayerPrefs.GetInt("tempo" + c.ToString()));
            c++;
        }
    }
    public void guardarPlayerPrefsTempo()
    {
        for (int i = 0; i < this.tempo.Count; i++)
        {
            PlayerPrefs.SetInt("tempo" + i, this.tempo[i]);
        }
    }
    public void lerPlayerPrefsPontos()
    {
        int c = 0;
        while (PlayerPrefs.GetInt("pontos" + c.ToString(), 9999999) != 9999999)
        {
            setAcertos(PlayerPrefs.GetInt("pontos" + c.ToString()));
            c++;
        }
    }
    public void guardarPlayerPrefsPontos()
    {
        for (int i = 0; i < this.pontos.Count; i++)
        {
            PlayerPrefs.SetInt("pontos" + i, this.pontos[i]);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Init()
    {
        if(playerScores != null)
        {
            return;
        }
        playerScores = new Dictionary<string, Dictionary<string, int>>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
