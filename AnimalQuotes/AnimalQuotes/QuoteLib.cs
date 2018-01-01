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
        private static Quote[] wisdomQuoteLib;

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

            //Quotes about love
            loveQuoteLib = new Quote[]
            {
                new Quote("Some people drink from the fountain of knowledge, others just gargle.","Robert Anthony"),
                new Quote("Love yourself. It is important to stay positive because beauty comes from the inside out.","Jenn Proske"),
                new Quote("You wanna know who I'm in love with? Read the first word again.","Anonymous"),
                new Quote("We all have baggage, find someone who loves you enough to help you unpack.","Anonymous"),
                new Quote("They say that love is more important than money, but have you ever tried to pay your bills with a hug?","Anonymous"),
                new Quote("Love your enemies. It makes them so damned mad.","P.D. East"),
                new Quote("I love being married. It's so great to find that one special person you want to annoy for the rest of your life.","Rita Rudner"),
                new Quote("Gravitation can not be held responsible for people falling in love.","Albert Einstein"),
                new Quote("Our love is like a train with no brakes, unstoppable.","Anonymous"),
            };

            //Quotes about wisdom
            wisdomQuoteLib = new Quote[]
            {
                new Quote("The only normal people are the ones that you don't know very well.","Alfred Adler"),
                new Quote("Time flies. It's up to you to be the navigator","Robert Orben"),
                new Quote("What soap is to the body, laughter is to the soul","Yiddish Proverb"),
                new Quote("If you can't get a compliment any other way, pay yourself one","Mark Twain"),
                new Quote("Some cause happiness wherever they go; others whenever they go.","Oscar Wilde"),
                new Quote("The harder you fall, the higher you bounce","Anonymous"),
                new Quote("I've learned that you can tell a lot about a person by the way (s)he handles these three things: a rainy day, lost luggage, and tangled Christmas tree lights.","Maya Angelou"),
                new Quote("Make allowances for your friends' imperfections as readily as you do for your own.", "H. Jackson Brown, Jr."),
                //new Quote(,),
                //new Quote(,),

            };
        }

    }
}
