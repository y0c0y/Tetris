using System;
using System.Threading;
using Tetris_GAME;
using Tetris_MainView;


namespace Csharp_Project
{
    static class Program
    {
        static void Main()
        {


            if (Start.MainView() == 0) Environment.Exit(0);
            else
            {
                Console.SetWindowSize(150, 40);


                Thread tetris = new Thread(new ThreadStart(Tetris.Game));

                tetris.Start();

                tetris.Join();
            }

        }
    }
}