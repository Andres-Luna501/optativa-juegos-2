using System;

[Serializable]
public class ScoreData
{
    public string nombre;
    public int score;

    public ScoreData(string nombreJugador, int puntuacion)
    {
        nombre = nombreJugador;
        score = puntuacion;
    }
}