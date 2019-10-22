using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspalhaCartas : MonoBehaviour
{
    [SerializeField] int numberOfCards;
    [SerializeField] int[] sorteadaValor = new int[15];
    [SerializeField] int[] sorteadaNaipe = new int[15];
    public GameObject prefabCarta;

    // Start is called before the first frame update
    void Start()
    {
        this.numberOfCards = GameConfigs.instance.getNumberOfCards();
        this.sorteadaValor = new int[numberOfCards];
        this.sorteadaNaipe = new int[numberOfCards];

        for(int c = 0; c<=this.numberOfCards; c++)
        {
            this.sorteadaValor[c] = Random.Range(0, 13);
            this.sorteadaNaipe[c] = Random.Range(0, 4);

            prefabCarta.GetComponent<Carta>().setValor(this.sorteadaValor[c]);
            prefabCarta.GetComponent<Carta>().setNaipe(this.sorteadaNaipe[c]);
            int x = (110 * c) + 185;
            Instantiate(prefabCarta, new Vector3(x, 250, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        }

        GameConfigs.instance.setCartasValor(this.sorteadaValor);
        GameConfigs.instance.setCartasNaipe(this.sorteadaNaipe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
