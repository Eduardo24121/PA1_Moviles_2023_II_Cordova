using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scrolee : MonoBehaviour
{
    [SerializeField] RawImage ScroolImage;
    private Rect rect;
    // Start is called before the first frame update
    void Start()
    {
        rect = ScroolImage.uvRect;
    }

    // Update is called once per frame
    void Update()
    {
        rect.x += Time.deltaTime;
        ScroolImage.uvRect = rect;  
    }
}
