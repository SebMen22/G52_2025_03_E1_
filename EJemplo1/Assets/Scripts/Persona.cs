using UnityEngine;
using System;



namespace packagePersona
{
    public class Persona
    {

        private string nameP;
        private string mailP;
        private string dirP;


        //-----------------------Constructor
        public Persona()
        {
        }

        public Persona(string nameP, string mailP, string dirP)
        {
            this.nameP = nameP;
            this.mailP = mailP;
            this.dirP = dirP;
        }


        //----------------------------- gets y Sets----------------------
        public string Namep { get => nameP; set => nameP = value; }
        public string MailP { get => mailP; set => mailP = value; }
        public string DirP { get => dirP; set => dirP = value; }
    }
}
