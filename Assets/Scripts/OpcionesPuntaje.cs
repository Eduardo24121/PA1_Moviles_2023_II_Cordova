using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OpcionesPuntaje : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencia al TextMeshProUGUI en el Canvas de la segunda escena

    private void Start()
    {
        // Buscar el ScoreManager en la escena actual
        ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

        if (scoreManager != null)
        {
            // Obtener el puntaje del ScoreManager
            float currentScore = scoreManager.GetScore();

            // Verificar si el TextMeshProUGUI está configurado
            if (scoreText != null)
            {
                // Actualizar el elemento TextMeshProUGUI con el puntaje
                scoreText.text = "Puntaje: " + currentScore.ToString("F0");
            }
        }
        else
        {
            Debug.LogWarning("ScoreManager no encontrado en la escena actual.");
        }
    }
}