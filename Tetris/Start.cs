using System;
using System.Threading;

namespace Tetris_MainView
{
    public class Start
    {
        // The currently selected menu
        public static int My_select = 2;
        // 이전 선택 메뉴
        public static int prev_select = 3;
        // 엔터 입력 여부(1 : 엔터 입력O, -1 : 엔터 입력X)
        public static int EnterProcess = -1;
        // 게임 시작 화면 (1 반환 : 게임 시작, 0 반환 : 게임 종료)

        public static void GameMenual()
        {
            Console.ResetColor();

            Console.SetWindowSize(130, 45);

            Console.Clear();

            Console.SetCursorPosition(0, 2);
            Console.WriteLine("          Press any key to close the game manual.                         IN MainView           IN Game  ");//0


            Console.SetCursorPosition(0, 5);
            Console.WriteLine("          ┌────────┐          ");//0
            Console.WriteLine("          │  Enter │                                                       Select Menu    /      None   ");//0
            Console.WriteLine("          └────────┘           ");//0



            Console.SetCursorPosition(0, 10);
            Console.WriteLine("          ┌─────┐         ");//0
            Console.WriteLine("          │  ↑ │                                                          MENU UP       /       Rotation (Counterclockwise)   ");//0
            Console.WriteLine("          └─────┘           ");//0

            Console.SetCursorPosition(0, 15);
            Console.WriteLine("          ┌─────┐          ");//0
            Console.WriteLine("          │  ↓ │                                                          MENU DOWN     /       Bloc move DOWN   ");//0
            Console.WriteLine("          └─────┘           ");//0

            Console.SetCursorPosition(0, 20);
            Console.WriteLine("          ┌─────┐          ");//0 
            Console.WriteLine("          │  ← │                                                          None          /       Block move LEFT   ");//0
            Console.WriteLine("          └─────┘           ");//0

            Console.SetCursorPosition(0, 25);
            Console.WriteLine("          ┌─────┐         ");//0 
            Console.WriteLine("          │  → │                                                          None          /       Block move RIGHT  ");//0
            Console.WriteLine("          └─────┘           ");//0



            Console.SetCursorPosition(0, 30);
            Console.WriteLine("          ┌────────────┐         ");//0
            Console.WriteLine("          │   SpaceBar │                                                   None          /       Block go to End  ");//0
            Console.WriteLine("          └────────────┘          ");//0


            Console.SetCursorPosition(0, 35);
            Console.WriteLine("          ┌────────┐         ");//0
            Console.WriteLine("          │   Esc  │                                                       None          /       EXIT  ");//0
            Console.WriteLine("          └────────┘          ");//0

            Console.SetCursorPosition(0, 40);
            Console.WriteLine("          ┌─────────────┐         ");//0
            Console.WriteLine("          │  Backspace  │                                                  None          /       Restart (Level 1)  ");//0
            Console.WriteLine("          └─────────────┘          ");//0

            Console.ReadLine();
        }
        public static int MainView()
        {

            Console.CursorVisible = false;

            GameMenual();

        mainview:

            Console.SetWindowSize(26, 16);

            My_select = 1;
            prev_select = 2;
            EnterProcess = -1;
            Console.Clear();
            Console.SetCursorPosition(0, 4);
            Console.Write("         T E T R I S     \n\n\n\n");
            Console.WriteLine("         START");
            Console.WriteLine("         HOW");
            Console.WriteLine("         EXIT");
            while (true)
            {
                Console.SetCursorPosition(9, 7 + My_select);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(My_select == 1 ? "START" : My_select == 2 ? "HOW" : "EXIT");
                Console.SetCursorPosition(9, 7 + prev_select);
                Console.ResetColor();
                Console.WriteLine(prev_select == 1 ? "START" : prev_select == 2 ? "HOW" : "EXIT");

                Thread key = new Thread(new ThreadStart(introProcessKeyInput));

                key.Start();

                key.Join();


                // enter 입력(메뉴 선택)
                if (EnterProcess > 0)
                {
                    // 게임 시작
                    if (My_select == 1)
                        return 1;
                    // 게임 방법
                    else if (My_select == 2)
                    {
                        GameMenual();
                        goto mainview;
                    }
                    // 게임 종료 
                    else if (My_select == 3)
                        return 0;
                }
            }
        }
        // 게임 시작 화면 키 입력 처리

        public static void introProcessKeyInput()
        {

            for (var i = 0; i < 20; i++)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {

                        case ConsoleKey.UpArrow:
                            if (My_select > 1) { prev_select = My_select; My_select--; }
                            break;
                        case ConsoleKey.Enter:
                            EnterProcess *= -1;
                            break;
                        case ConsoleKey.DownArrow:
                            if (My_select < 3) { prev_select = My_select; My_select++; }
                            break;
                        default:
                            break;
                    }
                }
                Thread.Sleep(10);
            }

        }
    }
}


