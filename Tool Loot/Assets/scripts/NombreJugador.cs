using UnityEngine;
using TMPro;

public class NombreJugador : MonoBehaviour
{
    public TMP_InputField inputNombre;

    public void GuardarNombre()
    {
        string nombre = inputNombre.text;

        if(nombre == "")
        {
            nombre = "Jugador";
        }

        PlayerPrefs.SetString("Jugador", nombre);

        Debug.Log("Nombre guardado: " + nombre);
    }
}