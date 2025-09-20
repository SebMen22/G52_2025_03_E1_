using packagePersona;
using packagePunto2D;
using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[Serializable]
public class Utilidades : MonoBehaviour
{
    [Serializable]
    public class DatosEstudiantes //---------------------------------------------------------
    {
        public List<Estudiante> estudiantes;
        public Punto2D punto2D;
    }

    [SerializeField]

    public UsaEstudiante estudiantes;

    [SerializeField]

    public Punto2D puntos2D;

    [ContextMenu("Save Data")]
    public void save() //----------------------------------------------------------------------
    {

        DatosEstudiantes datosEstudiantes = new DatosEstudiantes
        {
            estudiantes = estudiantes.listaE,
            punto2D = this.puntos2D
        };

        string jsonEstudiantes = JsonUtility.ToJson(datosEstudiantes, true);

        string path = Path.Combine(Application.persistentDataPath + "Utilidades.json");

        File.WriteAllText(path, jsonEstudiantes);

        Debug.Log(path);


    }
}