﻿using System;
using StringBuilder.Entities;

namespace StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando objetos da classe Comment 
            Comment C1 = new Comment("Have a nice trip");
            Comment C2 = new Comment("Wow that's awesome!");
            Comment C3 = new Comment("Good night");
            Comment C4 = new Comment("May the Force be with you");

            Post P1 = new Post(DateTime.Parse("21/06/2018 13:05:44"), "Traveling to New Zeanland", "I'm going to visit this wonderful coutry!", 12);
            Post P2 = new Post(DateTime.Parse("28/07/2018 23:14:19"), "Good night guys", "See you tomorrow", 5);

            P1.AddComment(C1);
            P1.AddComment(C2);
            P2.AddComment(C3);
            P2.AddComment(C4);

        }
    }
}
