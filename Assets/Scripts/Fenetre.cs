using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fenetre : MonoBehaviour
{
    public void Ouvrir()
    {
       this.gameObject.SetActive(true);
    }

    public void Fermer()
    {
        this.gameObject.SetActive(false);
    }
}
