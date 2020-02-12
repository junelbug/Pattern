using System;

namespace Pattern.Emoji
{
    class AngryEmoji : IEmoji
    {
        public void Express()
        {
            Console.WriteLine("Angerrr!!!!");
        }

        public bool isHappy()
        {
            return false ;
        }
    }
}
