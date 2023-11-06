using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GenerateurPizza : MonoBehaviour
{
    /// <summary>
    /// 
    /// </summary>
    [SerializeField, Tooltip("Modèle d'objet à cloner.")]
    private GameObject prototypePizza;
    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private GameObject pizza;
    /// <summary>
    /// 
    /// </summary>
    public static GenerateurPizza Instance { get; private set; }
    /// <summary>
    /// 
    /// </summary>
    [SerializeField]
    private TextMeshProUGUI tempsLivraison;
    /// <summary>
    /// 
    /// </summary>
    void Awake()
    {

        if (Instance == null)
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
    private void Start()
    {
        GameObject nouvellePizza = Instantiate(prototypePizza, transform);
    }

    public void GenererPizza()
    {
        GameObject piz = Instantiate(pizza, transform);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
            
        if (other.gameObject.layer == LayerMask.NameToLayer("Auto"))
        {
            Compteur.Instance.AjouterPizza();

            StartCoroutine("TempsLivraison");
            
            GenerateurCone.Instance.GenererCone();

            //Détruit seulement la pizza et non l'objet de collision au complet.
            Destroy(gameObject.transform.GetChild(0).gameObject);
        }
        
    }
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    private IEnumerator TempsLivraison()
    {
        float temps = 0.0f;

        while (!GenerateurCone.Instance.livrer)
        {
            temps += Time.deltaTime;
            
            tempsLivraison.text = temps.ToString(); 
            
            yield return null;
        }

    }
}

