using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecto : MonoBehaviour
{
    private float waitSeconds = 4f;
    IEnumerator DisableGameObject()
    {
        yield return new WaitForSeconds(waitSeconds);
        gameObject.SetActive(false);
    }
    private void OnEnable()
    {
        StartCoroutine(DisableGameObject() );
    }
    private void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 2);
    }
}
