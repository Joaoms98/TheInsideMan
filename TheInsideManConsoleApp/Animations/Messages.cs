namespace TheInsideManConsoleApp.Animations;

    public class Messages
    {
       private string logo =  
        @"
 ______  __                  ______                          __                                           
/\__  _\/\ \                /\__  _\                  __    /\ \              /'\_/`\                     
\/_/\ \/\ \ \___      __    \/_/\ \/     ___     ____/\_\   \_\ \     __     /\      \     __      ___    
   \ \ \ \ \  _ `\  /'__`\     \ \ \   /' _ `\  /',__\/\ \  /'_` \  /'__`\   \ \ \__\ \  /'__`\  /' _ `\  
    \ \ \ \ \ \ \ \/\  __/      \_\ \__/\ \/\ \/\__, `\ \ \/\ \L\ \/\  __/    \ \ \_/\ \/\ \L\.\_/\ \/\ \ 
     \ \_\ \ \_\ \_\ \____\     /\_____\ \_\ \_\/\____/\ \_\ \___,_\ \____\    \ \_\\ \_\ \__/.\_\ \_\ \_\
      \/_/  \/_/\/_/\/____/     \/_____/\/_/\/_/\/___/  \/_/\/__,_ /\/____/     \/_/ \/_/\/__/\/_/\/_/\/_/
                                                                                                          
                                                                                                          
                                         Press Enter To Start
                            Ajuste a tela até que todo o logo esteja visível                                                                      
        ";

       private string instructions =  
        @"
                                              Instructions:                      
                                     _______     _______     _______ 
                                    |\     /|   |\     /|   |\     /|
                                    | +---+ |   | +---+ |   | +---+ |
                                    | |   | |   | |   | |   | |   | |
                                    | |<- | |   | | ↵ | |   | | ->| |
                                    | +---+ |   | +---+ |   | +---+ |
                                    |/_____\|   |/_____\|   |/_____\|
                                    Esquerda    Selecionar   Direita                                 
        ";

       private string gameOver =  
        @"
                         ▄████  ▄▄▄      ███▄ ▄███▓▓█████     ▒█████   ██▒   █▓▓█████  ██▀███  
                        ██▒ ▀█▒▒████▄   ▓██▒▀█▀ ██▒▓█   ▀    ▒██▒  ██▒▓██░   █▒▓█   ▀ ▓██ ▒ ██▒
                       ▒██░▄▄▄░▒██  ▀█▄ ▓██    ▓██░▒███      ▒██░  ██▒ ▓██  █▒░▒███   ▓██ ░▄█ ▒
                       ░▓█  ██▓░██▄▄▄▄██▒██    ▒██ ▒▓█  ▄    ▒██   ██░  ▒██ █░░▒▓█  ▄ ▒██▀▀█▄  
                       ░▒▓███▀▒ ▓█   ▓██▒██▒   ░██▒░▒████▒   ░ ████▓▒░   ▒▀█░  ░▒████▒░██▓ ▒██▒
                        ░▒   ▒  ▒▒   ▓▒█░ ▒░   ░  ░░░ ▒░ ░   ░ ▒░▒░▒░    ░ ▐░  ░░ ▒░ ░░ ▒▓ ░▒▓░
                         ░   ░   ▒   ▒▒ ░  ░      ░ ░ ░  ░     ░ ▒ ▒░    ░ ░░   ░ ░  ░  ░▒ ░ ▒░
                       ░ ░   ░   ░   ▒  ░      ░      ░      ░ ░ ░ ▒       ░░     ░     ░░   ░ 
                             ░       ░  ░      ░      ░  ░       ░ ░        ░     ░  ░   ░     
                                                                           ░                    
        ";

       private string text1 =  
        @"
●▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ஜ۩۞۩ஜ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬●
     Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis 
    condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et 
    malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere
    eu, lectus. Nam mattis, felis ut adipiscing. 
●▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ஜ۩۞۩ஜ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬●
        ";

       private string text2 =  
        @"
●▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ஜ۩۞۩ஜ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬●
     Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam eget ligula eu lectus lobortis 
    condimentum. Aliquam nonummy auctor massa. Pellentesque habitant morbi tristique senectus et netus et 
    malesuada fames ac turpis egestas. Nulla at risus. Quisque purus magna, auctor et, sagittis ac, posuere
    eu, lectus. Nam mattis, felis ut adipiscing. 
●▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬ஜ۩۞۩ஜ▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬●
        ";

        public void LogoAnimation()
        {
            do
            {
               Console.WriteLine(logo);
            }while(Console.ReadKey().Key != ConsoleKey.Enter);
            Console.Clear();
        }

        public void InstructionsAnimation()
        {
            do
            {
                Console.WriteLine(instructions);
            }while(Console.ReadKey().Key != ConsoleKey.Enter);
            Console.Clear();
        }

        public void GameOverAnimation()
        {
            Console.WriteLine(gameOver);
            Environment.Exit(1);
        }

        public void Text1Animation()
        {
            Console.WriteLine(text1);
        }
        public void Text2Animation()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(text2);
            }while(Console.ReadKey().Key != ConsoleKey.Enter);
            Console.Clear();
        }
    }