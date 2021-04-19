using System;
using System.Collections.Generic;
using System.Text;

namespace LojaItens
{
    public class Personagem
    {
        public string nomedocara;
        public Int32 Dinheiro;
        public Dictionary<string, Item> Inventario = new Dictionary<string, Item>();

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
        public void Comprar()
        {
            Item varinha = new Item();
            varinha.Nome = "Cetro de gelo";
            varinha.Custo = 1200;
            varinha.Tipo = "feiticeiro";
            varinha.Descricao = "um poderoso cajado com uma pedra de gelo inderretível que dá dano adicional de frio às suas magias";
            varinha.Montante = 2;

            Item Foice = new Item();
            Foice.Nome = "sussurro das sombras";
            Foice.Custo = 2500;
            Foice.Tipo = "assassino";
            Foice.Descricao = "uma foice que divide seu dano entre físico e sombrio e aumenta sua furtividade";
            Foice.Montante = 2;

            Item Arco = new Item();
            Arco.Nome = "Furacão de Runnaan";
            Arco.Custo = 1300;
            Arco.Tipo = "Arqueiro";
            Arco.Descricao = "um arco que atira duas flechas de energia adicionais sem custo de munição a cada disparo";
            Arco.Montante = 2;

            Item Espada = new Item();
            Espada.Nome = "Lâmina do perseguidor";
            Espada.Custo = 2000;
            Espada.Tipo = "guerreiro";
            Espada.Descricao = "uma grande espada que acumila velocidade de movimento conforme o portador se locomove. Ao desferir um golpe, os acúmulos são transformados em dano adicional e zeram";
            Espada.Montante = 2;

            Item Flauta = new Item();
            Flauta.Nome = "Canto dos Esquecidos";
            Flauta.Custo = 900;
            Flauta.Tipo = "Bardo";
            Flauta.Descricao = "uma flauta que dá ao portador a habilidade de conjurar o Canto dos Esquecidos, que dobra todos os atributos de até 5 pessoas por um curto período de tempo";
            Flauta.Montante = 2;

            int quero = 1;
            if (quero > 0)
            {
                int certeza;
                string nomeItem;
                Console.WriteLine("Comerciante: Muito bem, Diga o nome do item que queres.");
                nomeItem = Console.ReadLine();
                if (nomeItem == varinha.Nome)
                {

                   if (varinha.Montante > 0)
                    {
                        if (Dinheiro >= varinha.Custo)
                        {
                            Console.Clear();
                            Console.WriteLine("Comerciante: Certeza que quer comprar esse item?");
                            Console.WriteLine(" [1] Sim");
                            Console.WriteLine("[outro] Não");
                            certeza = Convert.ToInt32(Console.ReadLine());
                            if (certeza == 1)
                            {

                                Dinheiro = Dinheiro - varinha.Custo;
                                Inventario.Add(varinha.Nome, varinha);
                                varinha.Montante = varinha.Montante - 1;
                                Console.WriteLine("Comerciante: Negócio fechado!");
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
                else if (nomeItem == Foice.Nome)
                {
                    if (Foice.Montante > 0)
                    {
                        if (Dinheiro >= Foice.Custo)
                        {
                            Console.Clear();
                            Console.WriteLine("Comerciante: Certeza que quer comprar esse item?");
                            Console.WriteLine(" [1] Sim");
                            Console.WriteLine("[outro] Não");
                            certeza = Convert.ToInt32(Console.ReadLine());
                            if (certeza == 1)
                            {
                                Dinheiro = Dinheiro - Foice.Custo;
                                Inventario.Add(Foice.Nome, Foice);
                                varinha.Montante = Foice.Montante - 1;
                                Console.WriteLine("Comerciante: Negócio fechado!");
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
                else if (nomeItem == Arco.Nome)
                {
                    if (Foice.Montante > 0)
                    {
                        if (Dinheiro >= Arco.Custo)
                        {
                            Console.Clear();
                            Console.WriteLine("Comerciante: Certeza que quer comprar esse item?");
                            Console.WriteLine(" [1] Sim");
                            Console.WriteLine("[outro] Não");
                            certeza = Convert.ToInt32(Console.ReadLine());
                            if (certeza == 1)
                            {
                                Dinheiro = Dinheiro - Arco.Custo;
                                Inventario.Add(Arco.Nome, Arco);
                                varinha.Montante = Arco.Montante - 1;
                                Console.WriteLine("Comerciante: Negócio fechado!");
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
                else if (nomeItem == Espada.Nome)
                {
                    if (Espada.Montante > 0)
                    {
                        if (Dinheiro >= Espada.Custo)
                        {
                            Console.Clear();
                            Console.WriteLine("Comerciante: Certeza que quer comprar esse item?");
                            Console.WriteLine(" [1] Sim");
                            Console.WriteLine("[outro] Não");
                            certeza = Convert.ToInt32(Console.ReadLine());
                            if (certeza == 1)
                            {
                                Dinheiro = Dinheiro - Espada.Custo;
                                Inventario.Add(Espada.Nome, Espada);
                                varinha.Montante = Espada.Montante - 1;
                                Console.WriteLine("Comerciante: Negócio fechado!");
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
                else if (nomeItem == Flauta.Nome)
                {
                    if (Flauta.Montante > 0)
                    {
                        if (Dinheiro >= Flauta.Custo)
                        {
                            Console.Clear();
                            Console.WriteLine("Comerciante: Certeza que quer comprar esse item?");
                            Console.WriteLine(" [1] Sim");
                            Console.WriteLine("[outro] Não");
                            certeza = Convert.ToInt32(Console.ReadLine());
                            if (certeza == 1)
                            {
                                Dinheiro = Dinheiro - Flauta.Custo;
                                Inventario.Add(Flauta.Nome, Flauta);
                                varinha.Montante = Flauta.Montante - 1;
                                Console.WriteLine("Comerciante: Negócio fechado!");
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
                Console.WriteLine("Comerciante: Aperte minha mão para selar o acordo, " + nomedocara);
                Console.WriteLine("[0] Apertar");
                Console.WriteLine("[outro] Apertar com vontade");
                quero = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }
        }
        public void Armario()
        {
            Console.WriteLine("Comerciante: Eis seus itens.");
            foreach (KeyValuePair<string, Item> Item in Inventario)
            {
                Console.WriteLine("Item: " + Item.Value.Nome);
                Console.WriteLine("Descrição: " + Item.Value.Descricao);
            }
        }
    }
}
