using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Bola bola;

    public GameObject playerCamera;

    public float distanciaBola = 2f;

    public float forcaArremesso = 5f;

    public bool segurandoBola = true;


   

    // Metodo start é executado apenas na criação do objeto
    void Start()
    {
        bola.GetComponent<Rigidbody>().useGravity = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (segurandoBola)
        {


            bola.transform.position = playerCamera.transform.position + playerCamera.transform.forward * distanciaBola;
            if (Input.GetMouseButtonDown(0))
            {
                bola.AtivarTrilha();
                segurandoBola = false;
                bola.GetComponent<Rigidbody>().useGravity = true;
                bola.GetComponent<Rigidbody>().AddForce(playerCamera.transform.forward * forcaArremesso);
            }
        }
    }
}
