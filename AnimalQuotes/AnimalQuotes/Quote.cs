using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalQuotes
{
    class Quote
    {
        private String text;
        private String author;
        private String attribute;


        //Quote structure
        public Quote(String text, String author)
            {
                this.text = text;
                this.author = author;   
            }

        public string Text { get => text; set => text = value; }
        public string Author { get => author; set => author = value; }
       

    }

    
       
   
      
}
