using packagePersona;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UsaEstudiante : MonoBehaviour
{

    [SerializeField]
    public List<Estudiante> listaE = new List<Estudiante>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Estudiante e1 = new Estudiante("2025_03", "Ing multimedia", "david castro", "dacastro@uao.edu.co",
          "carre 34");

        Estudiante e2 = new Estudiante("2023_02", "Ing Industrial", "Messi", "messi@uao.edu.co",
           "carre 10");


        listaE.Add(e1);
        listaE.Add(e2);

        for (int i = 0; i < listaE.Count; i++)
        {
            Debug.Log(" " + listaE[i].Namep + " Carrera " + listaE[i].NameCarreraE);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}