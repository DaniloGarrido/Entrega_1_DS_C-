using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OnBreak.Negocios
{

    public enum Tipo_Empresa
    {
        SPA  = 10,
        EIRL = 20,
        Limitada = 30,
        SociedadAnonima = 40
    }


    public enum ActividadEmpresa
    {
        Agropecuaria = 1,
        Mineria = 2,
        Manufactura = 3,
        Comercio = 4,
        Hoteleria = 5,
        Alimentos = 6,
        Transporte = 7,
        Servicios = 8
    }



    public enum Tipo_Evento
    {
        CoffeeBreak = 0,
        Cocktail = 1,
        Cena = 2

    }


    public enum Modalidad_CofeeBreak
    {
        LigthBreak = 0,
        JournalBreak = 1,
        DayBreak = 2
    }

    public enum Modalidad_Cocktail
    {
        QuickCocktail =0,
        AmbientCocktail =1
    }

    public enum Modalidad_Cena
    {
        Ejecutiva =0,
        Celebracion =1
    }



}
