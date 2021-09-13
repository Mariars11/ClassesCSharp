using System;

namespace Tutorial_Classe
{
    public class Wizard
    {
        public string nome;
        public string feiticoFavorito;
        public int quantFeitico; //usar o private para que apenas haja alteração dentro da propria classe
        public float experiencia;

        public static int Count; //static: shared by all the instances in the class
        public Wizard(string _nome, string _feiticoFavorito){ //class constructor - pensar como se fosse um metodo
            nome = _nome;
            feiticoFavorito = _feiticoFavorito;
            quantFeitico = 2;
            experiencia = 0;
            Count++;
        }

        public void UsarFeitico(){ //metodo - ação que o feiticeiro(a) realizará
            if(quantFeitico > 0){
                Console.WriteLine(nome + " usou o feitiço " + feiticoFavorito);
                quantFeitico--;
                experiencia += 0.3f;
            }
            else{
                Console.WriteLine(nome + " não possui feitiço disponível!");
            }
           
        }
        public void Meditacao(){
            Console.WriteLine(nome + " meditando para recuperar os feitiços ");
            quantFeitico = 2;
        }
    }
}