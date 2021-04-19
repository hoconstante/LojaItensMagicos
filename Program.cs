using System;

namespace LojaItens
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem voce = new Personagem();
            Loja loja = new Loja();
            loja.addCatalogo();
            int selec;
            do
            {
                Console.WriteLine("Comerciante: O que desejas, "+ voce.nomedocara+"?");
                Console.WriteLine("Você: Eu vim para...");
                Console.WriteLine(" [1] ver o catálogo");
                Console.WriteLine(" [2] Comprar um Item. ");
                Console.WriteLine(" [3] Ver meu inventário. ");
                Console.WriteLine(" [0] Eh... Na verdade, não tenho nada a fazer aqui.");
                selec = Convert.ToInt32(Console.ReadLine()); 
                Console.Clear();

                if (selec == 1)
                {                    
                    loja.ApresentarCatalogo();
                }
                else if ( selec == 2 && loja.VerificarEstoque() == true)
                {
                    voce.Comprar();
                }
                else if ( selec == 3)
                {
                    voce.Armario();
                }
                else if (selec != 0)
                {
                    Console.WriteLine("Comerciante: Não entendi, "+voce.nomedocara+". Faça uma colocação VÁLIDA. ");
                }

            }
            while (selec != 0);
            Console.WriteLine("Comerciante: Então vá na sombra, "+voce.nomedocara+".");
            Console.WriteLine("[pressione qualquer botão para sair da loja]");
            Console.ReadKey();
        }
    }
}
