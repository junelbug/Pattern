using Pattern.Emoji;
using System;
using System.Collections.Generic;

namespace Pattern
{
    public class Implementation
    {
        public static void BadSingleImp()
        {
            var factory = new BadEmojiFactory();

            IEmoji emoji = factory.Create1();

            emoji.Express();
        }

        public static void SingleImp(EmojiType type)
        {
            var factory = new EmojiFactory();

            IEmoji emoji = factory.Create(type);

            emoji.Express();

            if (emoji.isHappy())
            {
                Console.WriteLine("HAHAHAHAHHAHAHAHHAA");
            }
        }

        public static void IteratingImp(List<EmojiType> list)
        {
            var factory = new EmojiFactory(); 

            foreach (EmojiType type in list)
            {
                var emoji = factory.Create(type);
                emoji.Express(); 
            }
        }
    }
}
