using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Necessário para reiniciar a cena


public class player_live : MonoBehaviour
{

    public int vidaMaxima;
    public static int vidaAtual;
    public Text vidaText;
   


    // Start is called before the first frame update
    void Start()
    {
      vidaAtual = vidaMaxima;   
    }

    // Update is called once per frame
    void Update()
    {
           vidaText.text = vidaAtual.ToString();   
    }

    public void ReceberDano()
    {
        vidaAtual -= 1;

        if(vidaAtual <= 0 )
        {
            RestartGame();
            Debug.Log("Game Over");
        }
    }

     public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Carrega a cena atual
    }

     private void OnTriggerEnter2D(Collider2D other)
    {
        //esse metodo compara e ativa apenas UMA VEZ o o metodo ReceberDano
        if(other.gameObject.CompareTag("coin"))
        {
            other.gameObject.GetComponent<coin>().coletarCoin();
        }

          if(other.gameObject.CompareTag("lava"))
        {
            RestartGame();
        }

     
    }



}
