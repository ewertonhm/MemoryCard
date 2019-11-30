using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class IO : MonoBehaviour
{

    public void SaveFile(List<string> nome, List<int> acertos, List<int> numeroDeCartas, List<int> tempo)
    {
        string destination = Application.persistentDataPath + "./savenome.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(file, nome);
        file.Close();

        destination = Application.persistentDataPath + "/saveacertos.dat";

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        bf.Serialize(file, acertos);
        file.Close();

        destination = Application.persistentDataPath + "/savenumerodecartas.dat";

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        bf.Serialize(file, numeroDeCartas);
        file.Close();

        destination = Application.persistentDataPath + "/savetempo.dat";

        if (File.Exists(destination)) file = File.OpenWrite(destination);
        else file = File.Create(destination);

        bf.Serialize(file, tempo);
        file.Close();
    }

    public Ranking LoadFile()
    {
        string destination = Application.persistentDataPath + "/save.dat";
        FileStream file;

        if (File.Exists(destination)) file = File.OpenRead(destination);
        else
        {
            Debug.LogError("File not found");
            return null;
        }

        BinaryFormatter bf = new BinaryFormatter();
        Ranking r = (Ranking)bf.Deserialize(file);
        file.Close();

        return r;
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
