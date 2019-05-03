namespace Antywzorce.Spagetti
{
    public interface IDrink
    {
        int Napoj { get; set; }
        int Wielkosc { get; set; }
        int Mleko { get; set; }
        int IleMleka { get; set; }
        int Cukier { get; set; }
        int IleCukru { get; set; }

        string SelectSize();
    }
}