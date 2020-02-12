using Pattern.Emoji;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern
{
    public class EmojiFactory : IGoodFactory<IEmoji, EmojiType>
    {
        public IEmoji Create(EmojiType type)
        {
            switch (type)
            {
                case EmojiType.Angry:
                    return new AngryEmoji();
                case EmojiType.Happy:
                    return new HappyEmoji();
                case EmojiType.Sad:
                    return new SadEmoji();
                default:
                    return null;
            }
        }
    }
}
