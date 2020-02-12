using System;

namespace Pattern.Emoji
{
    class HappyEmoji : IEmoji
    {
        public void Express()
        {
            Console.WriteLine("Yeeeeeee");
        }

        public bool isHappy()
        {
            return true; 
        }
    }
}
