using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdicionandoComponentes : MonoBehaviour
{
    private SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        // atribuindo o componente:
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)){
            sprite.enabled = !sprite.enabled;
        }
    }
}
