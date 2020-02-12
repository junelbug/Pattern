using Pattern.Emoji;
using System.Collections.Generic;

namespace Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Implementation.BadSingleImp();

            var emojiType = EmojiType.Angry;
            Implementation.SingleImp(emojiType);

            var list = new List<EmojiType>()
            {
                EmojiType.Angry, EmojiType.Happy, EmojiType.Sad, EmojiType.Angry, EmojiType.Happy
            };
            Implementation.IteratingImp(list);
        }
    }
}
