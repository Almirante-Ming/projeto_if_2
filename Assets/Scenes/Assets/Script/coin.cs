using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class coin : MonoBehaviour
{

    public int coinInicial;
    public static int coinAtual;
    public Text coinText;
    public Text status;
    public static int contLevel;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        coinText.text = coinAtual.ToString();   
        status.text = contLevel.ToString();

       

    }

    public void coletarCoin()
    {
        coinAtual += 1;
        Debug.Log("Pegou coin");
        Destroy(this.gameObject);

    }

}
