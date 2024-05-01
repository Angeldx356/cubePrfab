using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciatePrefab : MonoBehaviour
{
    // Referencia al prefab que quieres instanciar
    public GameObject myPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instanciar el prefab en la posición y rotación deseadas
            Instantiate(myPrefab, new Vector3(0, 10, 0), Quaternion.identity);
        }
    }
}
