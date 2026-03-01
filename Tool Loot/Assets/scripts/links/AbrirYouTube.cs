using UnityEngine;

public class AbrirYouTube : MonoBehaviour
{
    public void AbrirURL(string url)
    {
        Application.OpenURL("https://www.youtube.com/results?search_query=como+agregar+links+a+un+proyecto+en+unity+2d");
    }
}