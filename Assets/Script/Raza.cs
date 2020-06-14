using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raza : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    public GameObject Jugar;
    public GameObject BotonAnterior;
    public GameObject BotonSiguiente;
    public GameObject BotonMedio;
    public GameObject BotonAtras;

    GameObject play1;
    GameObject play2;
    GameObject play3;

    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        BotonSiguiente.SetActive(false);
        BotonAnterior.SetActive(false);
        BotonMedio.SetActive(true);
        BotonAtras.SetActive(false);

        play1 = Instantiate(player1, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ActivarAnterior()
    {
        play1 = Instantiate(player1, new Vector3(-5.79f, 5.75f, 6.06f), Quaternion.identity) as GameObject;
        Destroy(play2, 0);
        Destroy(play3, 0);

        BotonAnterior.SetActive(false);
        BotonSiguiente.SetActive(false);
        BotonMedio.SetActive(true);
        BotonAtras.SetActive(false);
    }

    public void ActivarMedio()
    {
        play2 = Instantiate(player2, new Vector3(-5.79f, 5.75f, 6.06f), Quaternion.identity) as GameObject;
        Destroy(play1, 0);
        Destroy(play3, 0);

        BotonAtras.SetActive(false);
        BotonAnterior.SetActive(true);
        BotonSiguiente.SetActive(true);
        BotonMedio.SetActive(false);
    }

    public void ActivarSiguiente()
    {
        play3 = Instantiate(player3, new Vector3(-5.79f, 5.75f, 6.06f), Quaternion.identity) as GameObject;
        Destroy(play1, 0);
        Destroy(play2, 0);

        BotonAtras.SetActive(true);
        BotonAnterior.SetActive(false);
        BotonSiguiente.SetActive(false);
        BotonMedio.SetActive(false);
    }

    public void panelOpen()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }
}