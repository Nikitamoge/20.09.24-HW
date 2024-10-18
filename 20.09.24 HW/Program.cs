// Task 1
class Money
{
    private int dollars;
    private int cents;

    public int Dollars
    {
        get => dollars;
        set
        {
            if (value < 0)
                Console.WriteLine("Error, the value can't be lower than 0");
            else
                dollars = value;
        }
    }

    public int Cents
    {
        get => cents;
        set
        {
            if (value < 0)
                Console.WriteLine("Error, the value can't be lower than 0");
            else
            {
                dollars += value / 100;
                cents = value % 100;
            }
        }
    }

    public Money(int dollars, int cents)
    {
        Dollars = dollars;
        Cents = cents;
    }

    public void Display()
    {
        Console.WriteLine($"Amount: {Dollars} dollars and {Cents} cents");
    }
}

class Product
{
    private string name;
    private Money price;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public Money Price
    {
        get => price;
        set => price = value;
    }

    public Product(string name, Money price)
    {
        this.name = name;
        Price = price;
    }

    public void ReducePrice(int dollars, int cents)
    {
        Price.Dollars -= dollars;
        Price.Cents -= cents;
    }

    public void Display()
    {
        Console.WriteLine($"Product: {Name}");
        Price.Display();
    }
}


// Task 2
class Device
{
    protected string name;

    public string Name
    {
        get => name;
        set => name = value;
    }

    public Device(string name)
    {
        this.name = name;
    }

    public virtual void Sound()
    {
        Console.WriteLine($"{Name} is making a sound.");
    }

    public void Show()
    {
        Console.WriteLine($"Device Name: {Name}");
    }

    public virtual void Desc()
    {
        Console.WriteLine($"{Name} is a general device.");
    }
}

class Kettle : Device
{
    public Kettle() : base("Kettle") { }

    public override void Sound()
    {
        Console.WriteLine("Kettle is boiling.");
    }

    public override void Desc()
    {
        Console.WriteLine("Kettle heats water.");
    }
}

class Microwave : Device
{
    public Microwave() : base("Microwave") { }

    public override void Sound()
    {
        Console.WriteLine("Microwave is buzzing.");
    }

    public override void Desc()
    {
        Console.WriteLine("Microwave cooks food quickly.");
    }
}

class Car : Device
{
    public Car() : base("Car") { }

    public override void Sound()
    {
        Console.WriteLine("Car is honking.");
    }

    public override void Desc()
    {
        Console.WriteLine("Car is a means of transportation.");
    }
}

class Steamboat : Device
{
    public Steamboat() : base("Steamboat") { }

    public override void Sound()
    {
        Console.WriteLine("Steamboat is blowing its whistle.");
    }

    public override void Desc()
    {
        Console.WriteLine("Steamboat travels on water.");
    }
}


//Task 3
public abstract class MusicalInstrument
{
    protected string name;

    public string Name
    {
        get => name;
        set => name = value;
    }

    protected MusicalInstrument(string name)
    {
        this.name = name;
    }

    public abstract void Sound();
    public void Show()
    {
        Console.WriteLine($"Musical Instrument: {Name}");
    }

    public abstract void Desc();
    public abstract void History();
}

class Violin : MusicalInstrument
{
    public Violin() : base("Violin") { }

    public override void Sound()
    {
        Console.WriteLine("Violin is playing a beautiful melody.");
    }

    public override void Desc()
    {
        Console.WriteLine("Violin is a string instrument played with a bow.");
    }

    public override void History()
    {
        Console.WriteLine("Violin originated in Italy in the early 16th century.");
    }
}

class Trombone : MusicalInstrument
{
    public Trombone() : base("Trombone") { }

    public override void Sound()
    {
        Console.WriteLine("Trombone is producing a loud blast.");
    }

    public override void Desc()
    {
        Console.WriteLine("Trombone is a brass instrument with a slide.");
    }

    public override void History()
    {
        Console.WriteLine("Trombone dates back to the 15th century.");
    }
}

class Ukulele : MusicalInstrument
{
    public Ukulele() : base("Ukulele") { }

    public override void Sound()
    {
        Console.WriteLine("Ukulele is strumming cheerful chords.");
    }

    public override void Desc()
    {
        Console.WriteLine("Ukulele is a small string instrument from Hawaii.");
    }

    public override void History()
    {
        Console.WriteLine("Ukulele was introduced to Hawaii in the 19th century.");
    }
}

class Cello : MusicalInstrument
{
    public Cello() : base("Cello") { }

    public override void Sound()
    {
        Console.WriteLine("Cello is producing deep, rich tones.");
    }

    public override void Desc()
    {
        Console.WriteLine("Cello is a large string instrument played sitting down.");
    }

    public override void History()
    {
        Console.WriteLine("Cello evolved from earlier string instruments in the 16th century.");
    }
}


namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Money money = new Money(10, 150);
            Product product = new Product("PC", money);
            product.Display();
            product.ReducePrice(2, 50); 
            product.Display();

            // Task 2
            Device kettle = new Kettle();
            kettle.Show();
            kettle.Sound();
            kettle.Desc();

            Device microwave = new Microwave();
            microwave.Show();
            microwave.Sound();
            microwave.Desc();

            Device car = new Car();
            car.Show();
            car.Sound();
            car.Desc();

            Device steamboat = new Steamboat();
            steamboat.Show();
            steamboat.Sound();
            steamboat.Desc();

            // Task 3
            MusicalInstrument violin = new Violin();
            violin.Show();
            violin.Sound();
            violin.Desc();
            violin.History();

            MusicalInstrument trombone = new Trombone();
            trombone.Show();
            trombone.Sound();
            trombone.Desc();
            trombone.History();

            MusicalInstrument ukulele = new Ukulele();
            ukulele.Show();
            ukulele.Sound();
            ukulele.Desc();
            ukulele.History();

            MusicalInstrument cello = new Cello();
            cello.Show();
            cello.Sound();
            cello.Desc();
            cello.History();
        }
    }
}