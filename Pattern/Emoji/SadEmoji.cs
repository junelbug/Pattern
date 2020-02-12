using System;

namespace Pattern.Emoji
{
    class SadEmoji : IEmoji
    {
        public void Express()
        {
            Console.WriteLine("SAAAAADDDDDNNEESSSSS");
        }

        public bool isHappy()
        {
            return false;
        }
    }
}
