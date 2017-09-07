using System;

public abstract class Car : ICar
{
    private string model;
    private string color;

    protected Car(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public string Model
    {
        get => this.model;
        private set { this.model = value; }
    }

    public string Color
    {
        get => this.color;
        private set { this.color = value; }
    }

    public string Start() => "Engine start";

    public string Stop() => "Breaaak!";

    protected virtual string GetCarInfo()
    {
        return $"{this.Color} {GetType().Name} {this.Model}";
    }

    public override string ToString()
    {
             return $"{GetCarInfo()}{Environment.NewLine}" +
                    $"{Start()}{Environment.NewLine}{Stop()}";
    }
}
