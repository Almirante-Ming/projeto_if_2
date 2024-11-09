using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Necessário para reiniciar a cena

public class porta : MonoBehaviour
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
        if(other.gameObject.GetComponent("player"))
        {
            Debug.Log("colidiu");
          if(coin.coinAtual >= 5)
          {
            other.gameObject.GetComponent<player_live>().RestartGame();
            coin.contLevel += 1;
            
          }
          
        }
    }
}
