using UnityEngine;
using UnityEngine.UI;

public class Controller_Hud : MonoBehaviour
{
    public static bool gameOver = false;
    public Text distanceText;
    public Text gameOverText;
    private float distance = 0;
    private int ArreglarDistancia;
    
    void Start() 
    {
        gameOver = false;
        distance = 0;
        distanceText.text = distance.ToString();
        gameOverText.gameObject.SetActive(false);
    }
    void Update()
    {
        if (gameOver)   /// Si se activa el game over basicamente sale el texto burlandose que puse, te dice tu distancia recorrida y nada mas.
        {
            Time.timeScale = 0;
            gameOverText.text = "Skill Issue \n Total Distance: " + ArreglarDistancia.ToString();
            gameOverText.gameObject.SetActive(true);
        }
        else /// si NO se activa el game over se sigue aumentando tu distancia
        {
            distance += Time.deltaTime;
            ArreglarDistancia = ArreglarDistancia = (int)distance;
            distanceText.text = ArreglarDistancia.ToString();
        }
    }
}
