using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2309Clases
{
    class Country
    {
        //DEFINIR MIEMBROS DE LA CLASE
        //propiedades/atributos/datos 
        private int _countryId;
        private string _name;
        private string _population;

        //propiedades autoimplementadas
       //public string _altitude{ get; set; }


        //metodo constructor
        public Country(int countryId, string name, string population)
        {
            _countryId = countryId;
            _name = name;
            _population = population;
        }

        public Country(string Name)
        {
            _name = Name;
        }
        
        //metodos de propiedad
        //get -- obtiene el valor almacenado en la propiedad
        //set -- asignar un valor a la variable de propiedad

        //_paisId
        public void setCountryId(int countryId)
        {
            _countryId = countryId;
        }
        public int getCountryId()
        {
            return _countryId;
        }
        //_nombre
        public void setName(string name)
        {
            _name = name;
        }
    
        public string getName()
        {
           return _name;
        }
        //_poblacion
        //public void setPopulation(string population)
        //{
            //_population = population;
        //}
        //public string getPopulation()
        //{
       //     return _population;
       // }
        

        //METODOS
        public string getCountryInfo()
        {
            return _countryId + " " + _name + " " + _population + " ";
        }
    }
}
