namespace Pattern
{
    public interface IGoodFactory<R, T>
    {
        R Create(T type);
    }
}