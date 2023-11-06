using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateurCone : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField, Tooltip("Modèle d'objet à cloner.")]
    private GameObject cone;
    /// <summary>
    /// 
    /// </summary>
    public static GenerateurCone Instance { get; private set; }
    /// <summary>
    /// 
    /// </summary>
    private Vector3 position;
    /// <summary>
    /// 
    /// </summary>
    public bool livrer;
    /// <summary>
    /// 
    /// </summary>
    private int nombreLivraison; 

    /// <summary>
    /// 
    /// </summary>
    void Awake()
    {
        nombreLivraison = 0;
        
        livrer = false;
        
        GenererPosition();

        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void GenererPosition()
    {
        if (nombreLivraison == 0)
        {
            position.y = 0;
            position.z = 0;
            position.z= 0;
        }
        else if(nombreLivraison == 1)
        {
            position.x = 0;
            position.y = 0;
            position.z = 0;
        }
        else if(nombreLivraison == 2)
        {
            position.x = 0;
            position.y = 0;
            position.z = 0;
        }
        else if (nombreLivraison == 3)
        {
            position.x = 0;
            position.y = 0;
            position.z = 0;
        }
        else if (nombreLivraison == 4)
        {
            position.x = 0;
            position.y = 0;
            position.z = 0;
        }

    }
    /// <summary>
    /// 
    /// </summary>
    public void GenererCone()
    {
        GameObject nouveauCone = Instantiate(cone, transform);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer("Auto"))
        {
            Compteur.Instance.AjouterCone();

            GenerateurPizza.Instance.GenererPizza();

            livrer = true;

            Destroy(gameObject.transform.GetChild(0).gameObject);
        }
       
    }
}
