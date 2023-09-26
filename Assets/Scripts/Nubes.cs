using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nubes : MonoBehaviour
{
    public ObjectPooling Nube;
    public Transform Spawn;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var Go = Nube.GetGameObjectFromPool();
            if(Go == null)
            {
                return;
            }
            Go.transform.position = Spawn.position;
        }

        
    }
}
