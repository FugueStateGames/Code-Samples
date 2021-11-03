using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem 
{
    public static void SaveItems(Items items)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/items.bin";
        FileStream stream = new FileStream(path, FileMode.Create);

        ItemData data = new ItemData(items);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ItemData LoadItems()
    {
        string path = Application.persistentDataPath + "/items.bin";
        
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ItemData data = formatter.Deserialize(stream) as ItemData;
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }
}
