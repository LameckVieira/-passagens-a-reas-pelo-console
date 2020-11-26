using System;

namespace _passagens_a_reas_pelo_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = new string [5];
            string [] origem = new string [5];
            string [] destino = new string [5];
            string [] data = new string [5];
            // Menu
            Console.Clear();  
            Console.WriteLine ("-----------------------------------");
            Console.WriteLine ("----Sistema de passagens aéreas----");
            Console.WriteLine ("-----------------------------------"); 
            bool senhaValida;  
            do 
            {
                Console.WriteLine ("Digite sua senha");  
                string senha = Console.ReadLine ();  
                senhaValida = EfetuarLogin (senha);  
            } while (!senhaValida);  
                Console.Clear();  
            // Criar o menu 
            int escolha;  
            int contador = 0;  
            do 
            {
                Console.WriteLine ("Menu inicial"); 
                Console.WriteLine ("Seleciona uma opção"); 
                Console.WriteLine ("[1] - Cadastrar passagens");
                Console.WriteLine ("[2] - Lista de passageiros");
                Console.WriteLine ("[0] - Sair");
                escolha = int.Parse (Console.ReadLine ()); 
                 
                switch (escolha)
                { 
                    case 1:
                        //Cadastrar a passagem 
                            string resposta; 

                            do 
                            {
                                if(contador<5)
                                {
                                    Console.WriteLine ($"Digite o nome do {contador+1} Passageiro");  
                                    nomes [contador] = Console.ReadLine();  
                                    Console.WriteLine ($"Digite a origem do {contador + 1} e Passageiro");
                                    origem [contador] = Console.ReadLine();  
                                    Console.WriteLine ($"Digite o destino do {contador + 1} ° Passageiro");  
                                    destino [contador] = Console.ReadLine();  
                                    Console.WriteLine ($"Digite a data do vôo do {contador + 1}° Passageiro"); 
                                    data [contador] = Console.ReadLine ();
                                    contador ++;
                                }else{
                                    Console.WriteLine ("Limite excedido de passagens");
                                    break;
                                }
                                Console.WriteLine("Gostaria de cadastarar um novo passageiro? s/n");
                                resposta = Console.ReadLine();
                            }while (resposta == "s");
                    break;
                case 2:
                        for (var i = 0; 1 < 5; i++)
                        {
                            Console.WriteLine($"Pasageiro {nomes[i]}");
                        }
                    break;
                case 0:
                    //saida
                    Console.WriteLine("Obrigado! Volte sempre!");
                    break;
                default:
                Console.WriteLine("Opção inválida");
                    break;
                }
            } while (escolha != 0);

            //Função
            bool EfetuarLogin(string senha){
                if(senha == "123456"){
                    return true;
                }else{
                    Console.WriteLine("Senha incorreta");
                    return false;
                }
            }//fim efetuar login

        }
    }
}
