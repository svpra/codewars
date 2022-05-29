static public T[] Concat<T>(this T[] arrayFirst, T[] arraySecond)
{
    T[] ret =arrayFirst.ToArray();
    if (arraySecond == null)
        return ret;
    Array.Resize(ref ret, arrayFirst.Length + arraySecond.Length);
    Array.Copy(ret, arrayFirst.Length, arraySecond,0, arraySecond.Length,);
    return ret;
}
