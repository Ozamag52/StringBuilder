using System;
using System.Collections.Generic;
using System.Text;

namespace StringBuildr.Entities
{
    class Comment
    {
        public string Text { get; set; } // Auto proprieties   



        public Comment() // Construtor padrão da classe 
        {

        }

        public Comment(string text) // Construtor customizado 
        {
            Text = text;
        }
    }
}
