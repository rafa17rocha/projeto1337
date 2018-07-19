using EY.Reinf.Object.Enumeracoes;
using System;

namespace EY.Reinf.Object.Model.VALIDAR
{
    public static class FabricaEventosReinf
    {
        public static EventoReinf Fabricar(EventosReinf evento)
        {
            EventoReinf e = null;
            switch(evento)
            {
                case EventosReinf.R1000:
                    e = new R1000();
                    break;
                default:
                    throw new ArgumentException("evento = " + evento);
            }
            return e;
        }
    }
}
