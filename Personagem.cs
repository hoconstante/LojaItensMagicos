using System;
using System.Collections.Generic;
using System.Text;

namespace LojaItens
{
    public class Personagem
    {
        public string nomedocara;
        public int Dinheiro;
        public Dictionary<string, Item> Inventario = new Dictionary<string, Item>();
        public Dictionary<string, Item> Estoque = new Dictionary<string, Item>();
        
        public Personagem()
        {
            Console.WriteLine("Comerciante: Bem vindo à minha Loja, amigo. Qual a sua graça?");
            Console.Write("Você: Olá, me chamo... ");
            nomedocara = Console.ReadLine();
            Console.WriteLine("Comerciante: Essa bolsinha aí parece recheada, hein, " + nomedocara + ". Quanto tem aí? Pra comprar aqui vai precisar de alguns milhares de dinheiros");
            Console.WriteLine("** Quanto tem na bolsa? **");
            this.Dinheiro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Você: hum... uns " + this.Dinheiro + " dinheiros, mais ou menos");
            Console.WriteLine("Comerciante: " + this.Dinheiro + " dinheiros? É, dá pro gasto");            
        }
        public void addEstoque()
        {
            Item varinha = new Item();
            varinha.Nome = "sopro da nevasca"; varinha.Custo = 1200; varinha.Tipo = "feiticeiro"; varinha.Descricao = "um poderoso cajado com uma pedra de gelo inderretível que adiciona uma seta de gelo extra para toda magia lançada. A seta causa 40% do dano da magia lançada"; varinha.Montante = 3;
            Estoque.Add(varinha.Nome, varinha);

            Item Foice = new Item();
            Foice.Nome = "sussurro das sombras"; Foice.Custo = 2500; Foice.Tipo = "assassino"; Foice.Descricao = "uma foice que aumenta seu dano em 50% e o mescla entre dano físico e sombrio, te torna automaticamente furtivo durante a noite"; Foice.Montante = 3;
            Estoque.Add(Foice.Nome, Foice);
                     
            Item Arco = new Item();
            Arco.Nome = "fúria do vendaval"; Arco.Custo = 1300; Arco.Tipo = "Arqueiro"; Arco.Descricao = "um arco que atira duas flechas de energia adicionais sem custo de munição a cada disparo. As flechas de energia causam 25% do dano de sua flecha principal"; Arco.Montante = 3;
            Estoque.Add(Arco.Nome, Arco);
                        
            Item Espada = new Item();
            Espada.Nome = "lâmina do perseguidor"; Espada.Custo = 2000; Espada.Tipo = "guerreiro"; Espada.Descricao = "uma grande espada que acumula velocidade de movimento adicional de 0 a 60 pés conforme o portador se locomove. Ao desferir um golpe, os acúmulos são consumidos para causar 10% dos acúmulos como dano energético. +5% dano para cada 3 níveis"; Espada.Montante = 3;
            Estoque.Add(Espada.Nome, Espada);
                        
            Item Flauta = new Item(); 
            Flauta.Nome = "presságio da lembrança"; Flauta.Custo = 900; Flauta.Tipo = "Bardo"; Flauta.Descricao = "uma flauta que dá ao portador a habilidade de conjurar o Canto dos Esquecidos, que aumenta todos os atributos de até 5 pessoas em 50% por um curto período de tempo"; Flauta.Montante = 3;
            Estoque.Add(Flauta.Nome, Flauta);
                        
        }
        public void Comprar()
        {            
            int quero = 1;
            do
            {
                int certeza;
                string nomeItem;
                Console.WriteLine("Comerciante: Muito bem, Diga o nome do item que queres.");
                nomeItem = Console.ReadLine();
                foreach (KeyValuePair<string, Item> Item in Estoque)
                {
                    if (nomeItem == Item.Value.Nome)
                    {
                        if (Item.Value.Montante > 0)
                        {
                            if (Dinheiro >= Item.Value.Custo)
                            {
                                Console.Clear();
                                Console.WriteLine("Comerciante: Certeza que quer comprar esse item?");
                                Console.WriteLine(" [1] Sim");
                                Console.WriteLine("[outro] Não");
                                certeza = Convert.ToInt32(Console.ReadLine());
                                if (certeza == 1)
                                {
                                    Dinheiro = Dinheiro - Item.Value.Custo;

                                    Item.Value.Montante--;
                                    Console.WriteLine("Comerciante: Negócio fechado!");
                                    if (Inventario.ContainsKey(Item.Value.Nome))
                                    {
                                        foreach (KeyValuePair<string, Item> quantia in Inventario)
                                        {
                                            if (quantia.Value.Nome == Item.Value.Nome)
                                            {
                                                quantia.Value.Guardado++;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Item.Value.Guardado = 1;
                                        Inventario.Add(Item.Value.Nome, Item.Value);                                        
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Comerciante: Nada feito, então.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Comerciante: Você não tem dinheiro suficiente para comprar isso");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Comerciante: Infelizmente, não tenho mais desse item");
                        }
                    }
                }
                Console.WriteLine("Comerciante: Aperte minha mão para selar o acordo, " + nomedocara);
                Console.WriteLine("[0] Apertar");
                Console.WriteLine("[outro] Calma, Tenho mais coisas a comprar");
                quero = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            } while (quero != 0);
        }
        public void Armario()
        {
            Console.WriteLine("Comerciante: Eis seus itens. \n¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ ");
            foreach (KeyValuePair<string, Item> Item in Inventario)
            {
                Console.WriteLine("Item: " + Item.Value.Nome);
                Console.WriteLine("Descrição: " + Item.Value.Descricao);
                Console.WriteLine("Quantia: " + Item.Value.Guardado);
                Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            }
            Console.WriteLine("Saldo: " + Dinheiro + "\n \n¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨ \n ");    
        }
    }
}
