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
            varinha.Nome = "cetro de gelo";
            varinha.Custo = 1200;
            varinha.Tipo = "feiticeiro";
            varinha.Descricao = "um poderoso cajado com uma pedra de gelo inderretível que dá dano adicional de frio às suas magias";
            varinha.Montante = 2;
            Catalogo.Add(varinha.Nome, varinha);


            Item Foice = new Item();
            Foice.Nome = "sussurro das sombras";
            Foice.Custo = 2500;
            Foice.Tipo = "assassino";
            Foice.Descricao = "uma foice que divide seu dano entre físico e sombrio e aumenta sua furtividade";
            Foice.Montante = 2;
            Catalogo.Add(Foice.Nome, Foice);

            Item Arco = new Item();
            Arco.Nome = "furacão da sagacidade";
            Arco.Custo = 1300;
            Arco.Tipo = "Arqueiro";
            Arco.Descricao = "um arco que atira duas flechas de energia adicionais sem custo de munição a cada disparo";
            Arco.Montante = 2;
            Catalogo.Add(Arco.Nome, Arco);

            Item Espada = new Item();
            Espada.Nome = "lâmina do perseguidor";
            Espada.Custo = 2000;
            Espada.Tipo = "guerreiro";
            Espada.Descricao = "uma grande espada que acumila velocidade de movimento conforme o portador se locomove. Ao desferir um golpe, os acúmulos são transformados em dano adicional e zeram";
            Espada.Montante = 2;
            Catalogo.Add(Espada.Nome, Espada);

            Item Flauta = new Item();
            Flauta.Nome = "canto dos esquecidos";
            Flauta.Custo = 900;
            Flauta.Tipo = "Bardo";
            Flauta.Descricao = "uma flauta que dá ao portador a habilidade de conjurar o Canto dos Esquecidos, que dobra todos os atributos de até 5 pessoas por um curto período de tempo";
            Flauta.Montante = 2;
            Catalogo.Add(Flauta.Nome, Flauta);
        }
        
        public void ApresentarCatalogo()
        {
                Console.Clear();
                Console.WriteLine("Comerciante: Eis o que tenho aqui...");
                foreach (KeyValuePair<string, Item> Item in Catalogo)
                {
                    Console.WriteLine("Item: " + Item.Value.Nome);
                    Console.WriteLine("Custo: " + Item.Value.Custo);
                    Console.WriteLine("Tipo: " + Item.Value.Tipo);
                    Console.WriteLine("Descrição: " + Item.Value.Descricao);
                }
            }
        }
        
    }
}
