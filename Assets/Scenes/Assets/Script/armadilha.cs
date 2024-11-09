using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armadilha : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //esse metodo compara e ativa apenas UMA VEZ o o metodo ReceberDano
        if(other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<player_live>().ReceberDano();
        }
    }
}
