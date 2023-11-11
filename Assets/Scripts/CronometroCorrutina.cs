using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroCorrutina : MonoBehaviour
{
    private float tiempoPasado;
    private bool corriendo;
    void Start()
    {
        tiempoPasado = 0f;
        corriendo = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (corriendo == false)
            {
                StartCoroutine("ActualizarCronometro");
                corriendo = !corriendo;
            }
            else
            {
                StopCoroutine("ActualizarCronometro");
                corriendo = !corriendo;
            }
        }
    }

    IEnumerator ActualizarCronometro()
    {
        tiempoPasado += Time.deltaTime;
        Debug.Log("Tiempo Transcurrido: " + tiempoPasado.ToString("N2"));
        yield return null;
        StartCoroutine("ActualizarCronometro");
    }
}
