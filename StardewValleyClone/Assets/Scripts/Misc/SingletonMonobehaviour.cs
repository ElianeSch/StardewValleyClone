using UnityEngine;

public abstract class SingletonMonobehaviour<T> : MonoBehaviour where T:MonoBehaviour
{
    /* Dans une déclaration de classe, utilisez le modificateur abstract pour indiquer 
     * qu’une classe doit uniquement servir de classe de base pour d’autres classes, 
     * et ne pas être instanciée toute seule. 
     * Les membres définis comme abstraits doivent être implémentés par des classes non abstraites
     * dérivées de la classe abstraite.
     * Une classe non abstraite dérivée d’une classe abstraite 
     * doit inclure des implémentations réelles de tous les accesseurs et méthodes abstraits hérités.*/


    private static T instance;

    public static T Instance
    {
        get
        {
            return instance;
        }
    }

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this as T;
        }

        else
        {
            Debug.Log("Two instances : " + gameObject.name + " has been destroyed");
            Destroy(gameObject);

        }
    }


}
