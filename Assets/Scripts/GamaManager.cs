using UnityEngine;
using UnityEngine.InputSystem;

public class GamaManager : MonoBehaviour
{
   [SerializeField] private GameObject[] arrayGameObjects;
    
    HashTable<string, GameObject> ObjectsHashTables;
    


    private void Start()
    {
        ObjectsHashTables = new HashTable<string, GameObject>(arrayGameObjects.Length);
        AddGameObjects();
        CheckElements();
    }



    void AddGameObjects()
    {
        for (int i = 0; i < arrayGameObjects.Length; i++)
        {
            ObjectsHashTables.Add(arrayGameObjects[i].name, arrayGameObjects[i]);
        }
    }

    void CheckElements()
    {
        for (int i = 0; i < arrayGameObjects.Length; i++)
        {
            Debug.Log(ObjectsHashTables.ContainsKey(arrayGameObjects[i].name));
        }
    }
    


}
