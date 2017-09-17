﻿using System;

public class Scale<T> where T: IComparable<T>
{
    private T left;
    private T right;

    public Scale(T left, T right)
    {
        this.left = left;
        this.right = right;
    }

    public T GetHavier()
    {
        if (this.left.CompareTo(right) == 0) return default(T);

        if(this.left.CompareTo(right) > 0)  return this.left;

        return this.right;
    }
}
