using Bravo.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bravo
{
    

    class GestorFinalizarIntervención
    {
        Intervencion intervencion = new Intervencion();

        public List<Dotacion> crearDotaciones()
        {
            Dotacion dota1 = new Dotacion()
            {
                ID = 1,
                fechaSalida = DateTime.Today,
                kmUnidadSalida = 10548,
                unidadMovil = "AB 123 CD"
            };

            Dotacion dota2 = new Dotacion()
            {
                ID = 2,
                fechaSalida = DateTime.Today,
                kmUnidadSalida = 6546,
                unidadMovil = "AB 535 GF"
            };

            Dotacion dota3 = new Dotacion()
            {
                ID = 3,
                fechaSalida = DateTime.Today,
                kmUnidadSalida = 15480,
                unidadMovil = "CR 654 FT"
            };

            List<Dotacion> dotas = new List<Dotacion>();

            dotas.Add(dota1);
            dotas.Add(dota2);
            dotas.Add(dota3);

            return dotas;
        }

        public List<Intervencion> crearIntervenciones()
        {
            List<Dotacion> dotas = crearDotaciones();

            Intervencion inter1 = new Intervencion()
            {
                ID = 1,
                calle = "calle 51",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Incendio",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            Intervencion inter2 = new Intervencion()
            {
                ID = 2,
                calle = "calle 61",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Accidente de transito",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            Intervencion inter3 = new Intervencion()
            {
                ID = 3,
                calle = "calle 38",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Gatito en el arbol",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            Intervencion inter4 = new Intervencion()
            {
                ID = 4,
                calle = "calle 12",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Personas atrapadas en ascensor",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            Intervencion inter5 = new Intervencion()
            {
                ID = 5,
                calle = "New York",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Esta aterrizando una nave de Thanos",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            Intervencion inter6 = new Intervencion()
            {
                ID = 6,
                calle = "Barrio Jardin",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Accidente de transito",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            Intervencion inter7 = new Intervencion()
            {
                ID = 7,
                calle = "Av. Simpre Viva",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Incendio",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            Intervencion inter8 = new Intervencion()
            {
                ID = 8,
                calle = "Nueva Cordoba",
                fechaHotaSolicitud = DateTime.Today,
                resumenSiniestroInformante = "Fuga de gas",
                dotaciones = dotas,
                estadoActual = new EnCurso()
            };

            List<Intervencion> inters = new List<Intervencion>();

            inters.Add(inter1);
            inters.Add(inter2);
            inters.Add(inter3);
            inters.Add(inter4);
            inters.Add(inter5);
            inters.Add(inter6);
            inters.Add(inter7);
            inters.Add(inter8);

            return inters;
        }

        public List<Intervencion> obtenerIntervencionesEnCurso()
        {
            List<Intervencion> inters = crearIntervenciones();
            List<Intervencion> interEnCurso = new List<Intervencion>();

            foreach(Intervencion inter in inters)
            {
                if(inter.estaEnCurso())
                {
                    interEnCurso.Add(inter);
                }
            }

            return interEnCurso;
        }

        public void registrarFinalizacion(Intervencion inter, List<float> km, List<DateTime> fechaActual)
        {
            inter.finalizar(inter, km, fechaActual);
        }

        public bool validarKilometraje(float kmLlegada, float kmSalida)
        {
            if (kmLlegada > kmSalida)
                return true;

            return false;
        }
    }
}
