using System.Security.Cryptography.X509Certificates;

namespace Actividad4.Models;

public class Sala_Escape_05
{
    string[] Claves = new string[4] ;
 int AcertijosResueltos = 0;
    public Sala_Escape_05()
    {
        Claves[0] = "HONOR";
        Claves[1] = "SABIDURIA";
        Claves[2] = "LEALTAD";
        Claves[3] = "ASTUCIA";
        Claves[4] = "674976";
       Claves[5] = "SOMBRERO";
       Claves[6] = "43421";
    }

public void Sala1(string palabra){
if(AcertijosResueltos == 0 || 1 || 2 || 3){
    if(palabra == Claves[AcertijosResueltos]){
                AcertijosResueltos ++;
            }
}
if(AcertijosResueltos == 4 ){
    if(palabra== Claves[4] ){
    if(palabra == Claves[4]){
                AcertijosResueltos ++;
            }
}
if(AcertijosResueltos == 5 ){


}
 

}
    for(int i = 0; i <= 4; i++){
        
    }
}

}