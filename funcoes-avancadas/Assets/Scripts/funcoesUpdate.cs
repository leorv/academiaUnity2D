using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funcoesUpdate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("tempo de update: " + Time.deltaTime);
    }

    void FixedUpdate() {
        //faz o update em um tempo fixo, ex.: 20 ms
        Debug.Log("tempo do fixedUpdate: " + Time.deltaTime);    
    }

    void LateUpdate() {
        // é executada depois da update.
        Debug.Log("executada a lateUpdate.");    
    }
}
