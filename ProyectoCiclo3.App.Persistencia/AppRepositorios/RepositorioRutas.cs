using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1,origen="Manozalez",destino= "Airbus ",tiempo_estimado= 220},
                new Rutas{id=2,origen="A321",modelo= "Airbus ",tiempo_estimado= 220},
                new Rutas{id=3,origen="A330",modelo= "Airbus ",tiempo_estimado= 293},
                new Rutas{id=4,origen="A340",modelo= "Airbus ",tiempo_estimado= 419},
                new Rutas{id=5,origen="B737",modelo= "Boeing ",tiempo_estimado= 215},      
                new Rutas{id=6,origen="B777",modelo= "Boeing ",tiempo_estimado= 550}     
                                
                 };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetWithId(int id){
            return rutas.SingleOrDefault(a => a.id == id);
        }
    }
}