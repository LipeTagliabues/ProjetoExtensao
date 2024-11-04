using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Lixeira : MonoBehaviour
{
    public List <string> Trash;
    public TextMeshProUGUI pontuacaoTexto;
    private static int pontuacao = 0; 

    private void Start()
    {
        AtualizarTexto();
        pontuacao = 0;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
       

        if (Trash.Contains(other.tag))
        {
           
            pontuacao += 1;
        }
        else
        {
            if (pontuacao > 0)
            {
                pontuacao -= 1;
            }
        }

        AtualizarTexto();
        Destroy(other.gameObject);
    }


    private void AtualizarTexto()
    {
        pontuacaoTexto.text = pontuacao.ToString();
    }
}
