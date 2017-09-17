using System.Collections.Generic;

internal static class ArrayCreator
{
    public static T[] Create<T>(int length, T item)
    {
        T[] result = new T[length];
        return result;
    }
}
