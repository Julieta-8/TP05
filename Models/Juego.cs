using System.Security.Cryptography.X509Certificates;

namespace Actividad4.Models;

static class Juego
{
   static string[] Claves = new string[7];
   static int AcertijosResueltos = 0;
static bool Termiando = false;
    static Juego()
    {
        Claves[0] = "HONOR";
        Claves[1] = "SABIDURIA";
        Claves[2] = "LEALTAD";
        Claves[3] = "ASTUCIA";
        Claves[4] = "674976";
        Claves[5] = "SOMBRERO";
        Claves[6] = "43421";
    }

    static bool Verificar(string palabra)
    {
        bool EstaOK=false;
        if (palabra == Claves[AcertijosResueltos])
        {
            EstaOK = true;
            AcertijosResueltos++;
        }

        return EstaOK;
    
    }
    static string corregir()
    {
        bool EstaOK=false;
        string res= "";
        res="intentelo denuevo";
        return res;
    
    }
}