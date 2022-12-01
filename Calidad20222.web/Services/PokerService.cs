using Calidad20222.web.Models;

namespace Calidad20222.web.Services;

public class PokerService
{   
    public const String CARTA_MAYOR = "CARTA MAYOR";
    public const String DOBLE = "DOBLE";
    public const String DOBLE_PAREJA = "DOBLE PAREJA";
    public const String TRIO = "TRIO";
    public const String ESCALERA = "ESCALERA";
    public const String COLOR = "COLOR";
    public const String FULL = "FULL";
    public const String POKER = "POKER";
    public const String ESCALERACOLOR = "ESCALERA COLOR";
    public const String ESCALERAREAL = "ESCALERA REAL";
    
    public String GetJugada(List<Carta> cartas)
    {
        if (EsPoker(cartas))
            return POKER;
        if (EsFull(cartas))
            return FULL;
        if (EsColor(cartas))
            return COLOR;
        if (EsEscalera(cartas))
            return ESCALERA;
        if (EsTrio(cartas))
            return TRIO;
        if (EsDoblePareja(cartas))
            return DOBLE_PAREJA;
        if (EsDoble(cartas))
            return DOBLE;
        if (EsEscaleraColor(cartas))
            return ESCALERACOLOR;
        if (EsEscaleraReal(cartas))
            return ESCALERAREAL;
        return CARTA_MAYOR;
    }

    private bool EsColor(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Palo);
        return grouping.Count() == 1;
    }

    private bool EsEscalera(List<Carta> cartas)
    {
        cartas = cartas.OrderBy(o => o.Numero).ToList();
        for (var i = 0; i < cartas.Count - 1; i++)
        {
            if (cartas.ElementAt(i).Numero + 1 != cartas.ElementAt(i + 1).Numero)
                return false;
        }

        return true;
    }

    private bool EsFull(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 2;
    }
    private bool EsDoblePareja(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Count() == 3;
    }

    private bool EsPoker(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 3);
    }
    
    private bool EsTrio(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 2);
    }

    private bool EsDoble(List<Carta> cartas)
    {
        var grouping = cartas.GroupBy(o => o.Numero);
        return grouping.Any(g => g.Count() > 1);
    }

    private bool EsEscaleraColor(List<Carta> cartas)
    {
        var listaOrdenada = cartas.OrderByDescending(o=>o.Numero).ToList();
        var grouping = listaOrdenada.GroupBy(o => o.Palo);

        if (grouping.Count() == 1) {
            for (int i = 0; i < listaOrdenada.Count(); i++) {
                if (listaOrdenada[i].Numero + 1 != listaOrdenada[i + 1].Numero)
                    return false;
            }
            return true;
        }
        return false;
    }

    private bool EsEscaleraReal(List<Carta> cartas) {

        int[] temp = { 1, 10, 11, 12, 13 };

        for(int i=0; i<cartas.Count();i++)
        {
            if (cartas[i].Numero != temp[i])
                return false;
        }
        return true;
    }

}