using System;

namespace Tutorial_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação de um feiticeiro - instance of the class
            Wizard wizard01 = new Wizard("Parry Hopper", "Unexpecto Patronum"); 
            /* wizard01.nome = "Parry Hopper"; - fazer dessa forma ou como no parametro do metodo
            wizard01.feiticoFavorito = "Unexpecto Patronum"; */
            
            /* wizard01.quantFeitico = 2; - realizar dessa forma. ou fazer um default desses valores
            wizard01.experiencia = 0f; */

            //uso dos metodos
            Console.WriteLine("Feitiços restantes: " + wizard01.quantFeitico);
            wizard01.UsarFeitico();
            Console.WriteLine("Feitiços restantes: " + wizard01.quantFeitico);
            Console.WriteLine("Experiência: " + wizard01.experiencia);
            wizard01.Meditacao();
            Console.WriteLine("Feitiços restantes: " + wizard01.quantFeitico);

            Wizard wizard02 = new Wizard("Glindalf Merlison", "Abracadabra");
            
            wizard02.UsarFeitico();
            
            Console.WriteLine(Wizard.Count);
        }
    }
}
