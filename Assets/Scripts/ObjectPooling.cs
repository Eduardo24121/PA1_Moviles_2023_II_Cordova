using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public int AmountToPool = 10;
    public GameObject GameObjectPool;
    private List<GameObject> poolObjects = new List<GameObject>();
    void Start()
    {
        CreatePool();
    }

    void CreatePool()
    {
        for(int i = 0; i < AmountToPool; i++)
        {
            var tempGo = Instantiate(GameObjectPool);
            tempGo.SetActive(false);
            poolObjects.Add(tempGo);
        }
    }
    public GameObject GetGameObjectFromPool() 
    {
        for (int i = 0; i < AmountToPool; i++)
        {
            if(!poolObjects[i].activeInHierarchy)
            {
                return poolObjects[i];
            }
        }
        Debug.Log("Error");
        return null;
    }
}
