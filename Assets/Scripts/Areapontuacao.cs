using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Areapontuacao : MonoBehaviour
{
    public GameObject efeitoBola;

    private void Start()
    {
        efeitoBola.SetActive(false);
    }
    void OnTriggerEnter(Collider outroCollider)
    {
       if (outroCollider.GetComponent<Bola>())
        {
            Debug.Log("Fez Ponto");
            efeitoBola.SetActive(true);
        }
    }
}
