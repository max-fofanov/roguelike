﻿using System;
using System.Text;
using NetCoreAudio;

namespace roguelike_spbu
{
    public class Program
    {
        static ConsoleColor backgroundColor;
        static ConsoleColor foregroundColor;
        static Encoding encoding = Encoding.UTF8;


        public static void MakeConsoleReady()
        {
            Console.Clear();
            Console.CursorVisible = false;

            encoding = Console.OutputEncoding;
            backgroundColor = Console.BackgroundColor;
            foregroundColor = Console.ForegroundColor;

            Console.OutputEncoding = Encoding.UTF8;
            Statistics.InvokeCtor();
        }

        public static void NormilizeConsole()
        {
            Console.Clear();
            Console.CursorVisible = true;

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;
            Console.OutputEncoding = encoding;

            Statistics.statistics["maxLevel"] = Math.Max((int)Statistics.statistics["maxLevel"], GameInfo.player.LVL);
            Statistics.statistics["timeInGame"] = (long)Statistics.statistics["timeInGame"] + (DateTime.Now.Ticks - GameInfo.startTime);
            Statistics.SaveStatistics();

            Walkman.Stop();
            Environment.Exit(0);
        }

        static bool IsEqual(double x, double y, double exp = 0.1)
        {
            return Math.Abs(x - y) < exp;
        }
        static void Main(string[] args)
        {
            MakeConsoleReady();
            Game game = new Game();
            //Walkman.Play("./sounds/Bad theme. HоM&M III OST - Necropolis Town.wav");

            while (true)
            {
                game.FullTurn();
            }
        }
    }
}
