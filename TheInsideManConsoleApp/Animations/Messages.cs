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
        ";

       private string instructions =  
        @"
                                                 Instructions:                      
                                        _______     _______     _______ 
                                       |\     /|   |\     /|   |\     /|
                                       | +---+ |   | +---+ |   | +---+ |
                                       | |   | |   | |   | |   | |   | |
                                       | |<- | |   | |any| |   | |-> | |
                                       | +---+ |   | +---+ |   | +---+ |
                                       |/_____\|   |/_____\|   |/_____\|
                                        MoveLeft    NotMove    MoveRight                                 
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

        public void LogoAnimation()
        {
            do
            {
               Console.WriteLine(logo);
            }while(Console.ReadKey().Key != ConsoleKey.Enter);
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
        }
    }