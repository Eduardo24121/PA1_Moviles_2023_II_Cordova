using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referencia al objeto TextMeshProUGUI en el Canvas
    private float score = 0f;

    private void Start()
    {
        // Iniciar la suma de puntos por segundo
        InvokeRepeating("IncreaseScore", 1f, 1f);
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void IncreaseScore()
    {
        score += 1f;
        UpdateScoreText(); // Actualiza el texto del puntaje
    }

    public float GetScore()
    {
        return score;
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString("F0"); // "F0" para mostrar el puntaje sin decimales
        }
    }
}