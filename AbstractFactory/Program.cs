public interface IProcessor
{
    void Describe();
}

// ante bet7wl t3rf kol goz2 fe el 2awl lwa7dow we b3denn to23d tbny 3leh wahda wahda.
public class GamingProcessor : IProcessor
{
    public void Describe()
    {
        Console.WriteLine("GamingProcessor");
    }
}

public class OfficeProcessor : IProcessor
{
    public void Describe()
    {
        Console.WriteLine("OfficeProcessor");
    }
}

// hna kda e7na 5lsna el goz2 bta3 el processor we nrkz 3la gozx eltany
public interface IGraphicCard
{
    void Describe();
}

public class GamingGraphicCard : IGraphicCard
{
    public void Describe()
    {
        Console.WriteLine("GamingGraphicCard");
    }
}

public class OfficeGraphicCard : IGraphicCard
{
    public void Describe()
    {
        Console.WriteLine("OfficeGraphicCard");
    }
}

// 5lsna elkt3 elly hnbny beha, dlw2ty nbda ngm3
public interface IPcFactory
{
    IGraphicCard CreateGraphicCard();
    IProcessor CreateProcessor();
}

// dah bei2olk ezay kol 7aga el afdl ykon leha structure.
public class GamingPcFactory : IPcFactory
{
    public IGraphicCard CreateGraphicCard()
    {
        return new GamingGraphicCard();
    }

    public IProcessor CreateProcessor()
    {
        return new GamingProcessor();
    }
}

// kda 5lsna tgmi3t el gaming, dlw2ty nshof tgmi3t el office
public class OfficePcFactory : IPcFactory
{
    public IGraphicCard CreateGraphicCard()
    {
        return new OfficeGraphicCard();
    }

    public IProcessor CreateProcessor()
    {
        return new OfficeProcessor();
    }
}

class Program
{
    public static void Main()
    {
        IPcFactory pcFactory = new GamingPcFactory();
        pcFactory.CreateGraphicCard().Describe();
        pcFactory.CreateProcessor().Describe();
        IPcFactory pcFactory2 = new OfficePcFactory();
        pcFactory2.CreateGraphicCard().Describe();
        pcFactory2.CreateProcessor().Describe();
    }
}