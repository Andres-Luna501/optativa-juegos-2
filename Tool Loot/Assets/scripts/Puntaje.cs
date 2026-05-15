using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    public static Puntaje instancia;

    private float puntos;
    private TextMeshProUGUI textMesh;

    private void Awake()
    {
        instancia = this;
    }

    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }

    public void SumarPuntos(float puntosEntrada)
    
    {
        puntos += puntosEntrada;
    }

    public int ObtenerPuntos()
{
    return Mathf.RoundToInt(puntos);
}
}