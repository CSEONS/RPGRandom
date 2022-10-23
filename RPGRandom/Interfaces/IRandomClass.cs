internal interface IRandomClass<T>
{
    T Get();
    T Get(T max);
    T Range(T min, T max);
    void SetSeed(int seed);
}
