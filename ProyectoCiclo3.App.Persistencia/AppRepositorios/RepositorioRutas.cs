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
                new Rutas{id=1,origen="Manizalez",destino= "Tolima ",tiempo_estimado= 220},
                new Rutas{id=2,origen="New York",destino= "Soacha ",tiempo_estimado= 320},
                new Rutas{id=3,origen="Pereira",destino= "Galapa ",tiempo_estimado= 293},
                new Rutas{id=4,origen="Hula",destino= "Valle ",tiempo_estimado= 419},
                new Rutas{id=5,origen="Abidabi",destino= "Catar ",tiempo_estimado= 215},      
                new Rutas{id=6,origen="Buens Aires",destino= "Luqe ",tiempo_estimado= 550}     
                                
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