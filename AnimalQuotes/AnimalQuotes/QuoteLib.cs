using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalQuotes
{
    //Master library for quotes
    class QuoteLib
    {
        private static Quote[] alcoholQuoteLib;
        private static Quote[] loveQuoteLib;
        public QuoteLib()
        {
            //Quotes about alcohol
            alcoholQuoteLib = new Quote[]
    {

           new Quote("Always do sober what you said you’d do drunk.That will teach you to keep your mouth shut." , "Ernest Hemingway"),
           new Quote("“A drunk man’s words are a sober man’s thoughts." ,"Steve Fergosi"),
           new Quote("Beer is proof that God loves us and wants us to be happy.", "Benjamin Franklin"),
           new Quote("Here’s to alcohol, the cause of, and solution to, all life’s problems.", "Homer Simpson"),
           new Quote("Alcohol may be man’s worst enemy, but the bible says love your enemy.", "Frank Sinatra"),
           new Quote("Sometimes too much to drink is barely enough.", "Mark Twain"),
           new Quote("irst you take a drink, then the drink takes a drink, then the drink takes you.", "F. Scott Fitzgerald"),
           new Quote("Come, gentlemen, I hope we shall drink down all unkindness.", "William Shakespeare"),
           new Quote("Worthless people live only to eat and drink; people of worth eat and drink only to live.","Socrates"),
           new Quote("Some people drink from the fountain of knowledge, others just gargle.", "Robert Anthony")

   };
        }

    }
}
