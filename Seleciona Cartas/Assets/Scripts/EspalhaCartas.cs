using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EspalhaCartas : MonoBehaviour
{
    [SerializeField] int[] cartas;
    [SerializeField] string[] naipes;
    [SerializeField] int numberOfCards;
    [SerializeField] string[] sorteadas = new string[15];

    // Start is called before the first frame update
    void Start()
    {
        this.numberOfCards = GameConfigs.instance.getNumberOfCards();
        this.sorteadas = new string[numberOfCards];

        for(int c = 0; c<=this.numberOfCards; c++)
        {
            this.sorteadas[c] = string.Concat(this.cartas[Random.Range(0, 13)].ToString(), this.naipes[Random.Range(0, 4)].ToString());
        }
        GameConfigs.instance.setCartas(this.sorteadas);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
