using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

public static class SaveSystem 
{
    public static void SavePalyer (PlayerMovement playerMovement)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/Player.dd";
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(playerMovement);
        formatter.Serialize(stream, data);
        stream.Close();
    }
  
   

    public static PlayerData loadplayer()
    {
        string path = Application.persistentDataPath + "/Player.dd";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("faili ar moidzebna" + path);
            return null;
        }
    }

}

