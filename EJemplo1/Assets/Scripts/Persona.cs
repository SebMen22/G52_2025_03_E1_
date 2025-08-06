using UnityEngine;
using System;



namespace packagePersona
{
    public class Persona
    {

        private string namep;
        private string mailP;
        private string dirP;

        public Persona()
        {
        }

        public Persona(string namep, string mailP, string dirP)
        {
            this.namep = namep;
            this.mailP = mailP;
            this.dirP = dirP;
        }

        public string Namep { get => namep; set => namep = value; }
        public string MailP { get => mailP; set => mailP = value; }
        public string DirP { get => dirP; set => dirP = value; }
    }
}
