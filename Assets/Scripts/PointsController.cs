using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Lixeira : MonoBehaviour
{
    public string Trash;
    public TextMeshProUGUI pontuacaoTexto;
    private static int pontuacao = 0; 

    private void Start()
    {
        AtualizarTexto();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag(Trash))
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
