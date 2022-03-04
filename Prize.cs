using System;

namespace Quest
{
    public class Prize
    {
        private string _text {get;}

        public Prize(string text)
        {
            _text=text;
        }
        public void showPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {
                for (int i = 0; i < adventurer.Awesomeness; i++)
                {
                    Console.WriteLine($"{_text}");
                }
            } else
            {
                Console.WriteLine("What a terrible adventurer, you get nothing");
            }  
        }
    }
}