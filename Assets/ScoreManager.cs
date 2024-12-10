using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Para cambiar entre escenas

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Texto UI que muestra la puntuación
    private int score = 0;  // Puntuación actual

    // Método para sumar puntos
    public void AddScore(int value)
    {
        score += value;  // Aumenta la puntuación
        UpdateScoreText();  // Actualiza el texto de la UI

        // Verificar si se alcanzaron 10 monedas
        if (score >= 10)
        {
            LoadWinnerScene();  // Cambiar a la escena de Winner
        }
    }

    // Actualiza el texto de la puntuación
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    // Cargar la escena de Winner
    void LoadWinnerScene()
    {
        // Almacenar la puntuación en PlayerPrefs para mostrarla en la escena de Winner
        PlayerPrefs.SetInt("FinalScore", score);
        SceneManager.LoadScene("WinnerScene");
    }
}
