using UnityEngine;
using Firebase;
using Firebase.Database;
using Firebase.Extensions;

public class DBManager : MonoBehaviour
{
    FirebaseApp app;
    DatabaseReference DBreference;

    void Start()
    {
        InicializarDB();
    }

    void Update()
{
    if (Input.GetKeyDown(KeyCode.G))
    {
        GuardarScoreActual();
    }
}

    void InicializarDB()
    {
        FirebaseApp.CheckAndFixDependenciesAsync().ContinueWithOnMainThread(task =>
        {
            DependencyStatus dependencyStatus = task.Result;

            if (dependencyStatus == DependencyStatus.Available)
            {
                app = FirebaseApp.DefaultInstance;

                DBreference = FirebaseDatabase.DefaultInstance.RootReference;

                Debug.Log("Firebase conectado");
            }
            else
            {
                Debug.LogError("Error Firebase");
            }
        });
    }

    public void GuardarScore(string NombreJugador, int score)
    {
        string key = DBreference.Child("scores").Push().Key;

        ScoreData data = new ScoreData(NombreJugador, score);

        string json = JsonUtility.ToJson(data);

        DBreference.Child("scores").Child(key).SetRawJsonValueAsync(json);

        Debug.Log("Score enviado");
    }

    public void GuardarScoreActual()
{
    string nombre = PlayerPrefs.GetString("Jugador");

    int puntos = Puntaje.instancia.ObtenerPuntos();

    GuardarScore(nombre, puntos);

    Debug.Log("Datos reales enviados");
}
}