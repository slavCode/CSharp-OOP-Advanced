﻿using System;

public class Circle : IDrawable
{
    private int radius;

    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public int Radius
    {
        get => this.radius;
        private set { this.radius = value; }
    }


    public void Draw()
    {
        for (double y = this.Radius; y >= -this.Radius; --y)
        {
            double r_in = this.Radius - 0.4;
            double r_out = this.Radius + 0.4;

            for (double x = -this.Radius; x < r_out; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= r_in * r_in && value <= r_out * r_out)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }

            Console.WriteLine();
        }
    }
}
