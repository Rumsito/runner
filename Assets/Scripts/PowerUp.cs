using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public bool PlayerTouched;
    public GameObject caja;
    void Start() /// Indico que es falso que haya tocado a el jugador y que busque el objeto caja para saber cual es
    {
        PlayerTouched = false;
        caja = GameObject.Find("caja");

    }

    void OnTriggerEnter(Collider other) /// Indico que si toca el jugador se active un true y se destruya lo que toco el jugador
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerTouched = true;
            Destroy(other.gameObject);
        }

    }
    void Update()
    {
        if (PlayerTouched == true)
        {
            GameObject.Find("Caja").SetActive(true);  /// Se que no funca, pero queria que la caja entonces se active desde el inspector para tapar al jugador y salvarlo de un obstaculo
        }
    }
}