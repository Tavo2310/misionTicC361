using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioAviones
    {
        List<Aviones> aviones;
 
    public RepositorioAviones()
        {
            aviones= new List<Aviones>()
            {
                new Aviones{id=1,marca="A320",modelo= "Airbus ",numero_asientos= "220",numero_toilets= "3",capacidad_max_peso= 1},
                new Aviones{id=2,marca="A321",modelo= "Airbus ",numero_asientos= "220",numero_toilets= "3",capacidad_max_peso= 1},
                new Aviones{id=3,marca="A330",modelo= "Airbus ",numero_asientos= "293",numero_toilets= "4",capacidad_max_peso= 10},
                new Aviones{id=4,marca="A340",modelo= "Airbus ",numero_asientos= "419",numero_toilets= "6",capacidad_max_peso= 16},
                new Aviones{id=5,marca="B737",modelo= "Boeing ",numero_asientos= "215",numero_toilets= "3",capacidad_max_peso= 2},      
                new Aviones{id=6,marca="B777",modelo= "Boeing ",numero_asientos= "550",numero_toilets= "7",capacidad_max_peso= 18}  
                                
                 };
        }
 
        public IEnumerable<Aviones> GetAll()
        {
            return aviones;
        }
 
        public Aviones GetWithId(int id){
            return aviones.SingleOrDefault(a => a.id == id);
        }
    }
}