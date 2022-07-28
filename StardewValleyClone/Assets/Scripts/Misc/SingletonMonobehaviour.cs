using UnityEngine;

public abstract class SingletonMonobehaviour<T> : MonoBehaviour where T:MonoBehaviour
{
    /* Dans une d�claration de classe, utilisez le modificateur abstract pour indiquer 
     * qu�une classe doit uniquement servir de classe de base pour d�autres classes, 
     * et ne pas �tre instanci�e toute seule. 
     * Les membres d�finis comme abstraits doivent �tre impl�ment�s par des classes non abstraites
     * d�riv�es de la classe abstraite.
     * Une classe non abstraite d�riv�e d�une classe abstraite 
     * doit inclure des impl�mentations r�elles de tous les accesseurs et m�thodes abstraits h�rit�s.*/


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
