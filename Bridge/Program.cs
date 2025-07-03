using System;

public interface IPrinter
{
    string Print();
}

public class LaserPrinter : IPrinter
{
    public string Print()
    {
        return "using Laser Printer";
    }
}

public class StandardPrinter : IPrinter
{
    public string Print()
    {
        return "using Standard Printer";
    }
}

public abstract class Document
{
    protected IPrinter Printer;

    public Document(IPrinter printer)
    {
        Printer = printer;
    }

    public abstract string Print();
}

public class PDFDocument : Document
{
    public PDFDocument(IPrinter printer) : base(printer)
    {
    }

    public override string Print()
    {
        return $"Printing PDF {Printer.Print()}";
    }
}

public class WordDocument : Document
{
    public WordDocument(IPrinter printer) : base(printer)
    {
    }

    public override string Print()
    {
        return $"Printing Word {Printer.Print()}";
    }
}

public class ExcelDocument : Document
{
    public ExcelDocument(IPrinter printer) : base(printer)
    {
    }

    public override string Print()
    {
        return $"Printing Excel {Printer.Print()}";
    }
}

public class BridgePattern
{
    public static void Main(string[] args)
    {
        Document doc1 = new PDFDocument(new LaserPrinter());
        Console.WriteLine(doc1.Print());

        Document doc2 = new WordDocument(new StandardPrinter());
        Console.WriteLine(doc2.Print());
    }
}
