using Pattern.Emoji;

namespace Pattern
{
    class BadEmojiFactory : IBadFactory<IEmoji>
    {
        public IEmoji Create1()
        {
            return new AngryEmoji();
        }

        public IEmoji Create2()
        {
            return new HappyEmoji();
        }

        public IEmoji Create3()
        {
            return new SadEmoji();
        }
    }
}
