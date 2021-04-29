using System;
using System.Collections.Generic;
using System.Text;

namespace LojaItens
{
    public class Loja
    {
        public Dictionary<string, Item> Catalogo = new Dictionary<string, Item>();
        public void addCatalogo()
        {
            Item varinha = new Item();
            varinha.Nome = "sopro da nevasca"; varinha.Custo = 1200; varinha.Tipo = "feiticeiro"; varinha.Descricao = "um poderoso cajado com uma pedra de gelo inderretível que adiciona uma seta de gelo extra para toda magia lançada. A seta causa 40% do dano da magia lançada"; varinha.Montante = 3;
            Catalogo.Add(varinha.Nome, varinha);


            Item Foice = new Item();
            Foice.Nome = "sussurro das sombras"; Foice.Custo = 2500; Foice.Tipo = "assassino"; Foice.Descricao = "uma foice que aumenta seu dano em 50% e o mescla entre dano físico e sombrio, te torna automaticamente furtivo durante a noite"; Foice.Montante = 3;
            Catalogo.Add(Foice.Nome, Foice);

            Item Arco = new Item();
            Arco.Nome = "fúria do vendaval"; Arco.Custo = 1300; Arco.Tipo = "Arqueiro"; Arco.Descricao = "um arco que atira duas flechas de energia adicionais sem custo de munição a cada disparo. As flechas de energia causam 25% do dano de sua flecha principal"; Arco.Montante = 3;
            Catalogo.Add(Arco.Nome, Arco);

            Item Espada = new Item();
            Espada.Nome = "lâmina do perseguidor"; Espada.Custo = 2000; Espada.Tipo = "guerreiro"; Espada.Descricao = "uma grande espada que acumula velocidade de movimento adicional de 0 a 60 pés conforme o portador se locomove. Ao desferir um golpe, os acúmulos são consumidos para causar 10% dos acúmulos como dano energético. +5% dano para cada 3 níveis"; Espada.Montante = 3;
            Catalogo.Add(Espada.Nome, Espada);

            Item Flauta = new Item();
            Flauta.Nome = "presságio da lembrança"; Flauta.Custo = 900; Flauta.Tipo = "Bardo"; Flauta.Descricao = "uma flauta que dá ao portador a habilidade de conjurar o Canto dos Esquecidos, que aumenta todos os atributos de até 5 pessoas em 50% por um curto período de tempo"; Flauta.Montante = 3;
            Catalogo.Add(Flauta.Nome, Flauta);
        }
        
        public void ApresentarCatalogo()
        {
                Console.Clear();
                Console.WriteLine("Comerciante: Eis o que tenho aqui... \n¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ ");
            foreach (KeyValuePair<string, Item> Item in Catalogo)
                {
                    Console.WriteLine("Item:\t \t " + Item.Value.Nome);
                    Console.WriteLine("Custo:\t \t " + Item.Value.Custo);
                    Console.WriteLine("Tipo:\t \t " + Item.Value.Tipo);
                    Console.WriteLine("Descrição:\t " + Item.Value.Descricao);
                    Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
                }
                Console.WriteLine("\n");
            
        }
        
    }        
    
}

