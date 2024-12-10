using UnityEngine;
using UnityEngine.UI;

public class WinnerSceneManager : MonoBehaviour
{
    public Text coinsText; // Texto para mostrar la cantidad de monedas recolectadas

    void Start()
    {
        // Obtener la puntuación final de PlayerPrefs
        int finalScore = PlayerPrefs.GetInt("FinalScore", 0);

        // Actualizar el texto con la puntuación final
        coinsText.text = "Monedas recolectadas: " + finalScore.ToString();
    }
}
