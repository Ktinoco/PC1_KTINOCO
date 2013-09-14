using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using SOAPServices.Dominio;
using SOAPServices.Persistencia;

namespace SOAPServices
{
  
    public class Asesores : IAsesores
    {

        private AsesorDAO asesorDAO = null;
        private AsesorDAO AsesorDAO
        {
            get
            {
                if (asesorDAO == null)
                    asesorDAO = new AsesorDAO();
                return asesorDAO;
            }
        }

        private SedeDAO sedeDAO = null;
        private SedeDAO SedeDAO
        {
            get
            {
                if (sedeDAO == null)
                    sedeDAO = new SedeDAO();
                return sedeDAO;
            }
        }
      

        public Asesor CrearAsesor(string nombre, string correo, int sede)
        {
            Sede sedeExistente = SedeDAO.Obtener(sede); 
            Asesor nuevoAsesor = new Asesor()
            {
                Nombre = nombre,
                Correo = correo,
                Sede = sedeExistente
            };
           return  AsesorDAO.Crear(nuevoAsesor);
        }

        public Asesor ObtenerAsesor(int codigo)
        {
            return AsesorDAO.Obtener(codigo);
        }

        public Asesor ModificarAsesor(int codigo, string nombre, string correo, int sede)
        {
            Sede sedeExistente = SedeDAO.Obtener(sede);
            Asesor updateAsesor = new Asesor()
            {
                Codigo = codigo,
                Nombre = nombre,
                Correo = correo,
                Sede = sedeExistente
            };
            return AsesorDAO.Modificar(updateAsesor);
        }

        public void EliminarAsesor(int codigo)
        {
            Asesor asesorexistente = AsesorDAO.Obtener(codigo);
            AsesorDAO.Eliminar(asesorexistente);
        }

        public List<Asesor> ListaAsesores()
        {
            return AsesorDAO.ListarTodos().ToList();
        }
    }
}
