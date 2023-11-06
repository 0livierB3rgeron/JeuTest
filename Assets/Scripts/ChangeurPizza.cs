using System;
using UnityEngine;
using UnityEngine.Events;

public abstract class ChangeurPizza : MonoBehaviour
{
    
    [SerializeField]
    protected UnityEvent<object[]> OnChangementValeur;

    public abstract object[] GetValeurs();
}