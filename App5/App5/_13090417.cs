using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using Newtonsoft.Json;
using SQLite;

namespace App5
{
    [Table("_13090417")]
    public class _13090417
    {
        string matricula;
        string nombre;
        string apellidos;
        string direccion;
        string telefono;
        string carrera;
        string semestre;
        string correo;
        string github;
        bool deleted;

        [JsonProperty(PropertyName = "id")]
        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        [JsonProperty(PropertyName = "Nombre")]
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        [JsonProperty(PropertyName = "Apellidos")]
        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        [JsonProperty(PropertyName = "Direccion")]
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        [JsonProperty(PropertyName = "Telefono")]
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        [JsonProperty(PropertyName = "Carrera")]
        public string Carrera
        {
            get { return carrera; }
            set { carrera = value; }
        }

        [JsonProperty(PropertyName = "Semestre")]
        public string Semestre
        {
            get { return semestre; }
            set { semestre = value; }
        }

        [JsonProperty(PropertyName = "Correo")]
        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        [JsonProperty(PropertyName = "Github")]
        public string Github
        {
            get { return github; }
            set { github = value; }
        }

        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }

    }
}
