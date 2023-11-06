using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Compteur : ChangeurPizza
{

    public static Compteur Instance { get; private set; }


    private int nombrePizza;


    private int nombreCone;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        nombrePizza = 0;
        nombreCone = 0;
    }

    private void Start()
    {
        Notifier();
    }

 
    public void AjouterPizza(int nombrePizza = 1)
    {
        this.nombrePizza += nombrePizza;
        Notifier();
    }


    public void AjouterCone(int nombreCone = 1)
    {
        this.nombreCone += nombreCone;
        Notifier();
    }

    private void Notifier()
    {
        OnChangementValeur?.Invoke(GetValeurs());
    }

    public override object[] GetValeurs()
    {
        return new object[] { nombrePizza, nombreCone };
    }
}
