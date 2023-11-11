using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CronometroInvoke : MonoBehaviour
{
    private float tiempoPasado;
    private bool corriendo;
    void Start()
    {
        tiempoPasado = 0;
        corriendo = false;
        // InvokeRepeating("ActualizarCronometro",0,1);

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            if (corriendo == false)
            {
                InvokeRepeating("ActualizarCronometro",0,1);
                corriendo = !corriendo;
            }
            else
            {
                CancelInvoke("ActualizarCronometro");
                corriendo = !corriendo;
            }
        }
    }

    public void ActualizarCronometro(){
        tiempoPasado += 1;
        Debug.Log("Tiempo Transcurrido: " + tiempoPasado.ToString("N2"));
    }


}
