using System;
public class UnitConverter
{
    int ratio;
    public UnitConverter(int unitRatio) { ratio = unitRatio; }
    public int converter(int unit) { return unit * ratio; }
}
class Test
{
    static void Main()
    {
        UnitConverter feetToInchesConverter = new UnitConverter(12);
        UnitConverter milesToFeetConverter = new UnitConverter(5289);
        Console.WriteLine(feetToInchesConverter.converter(10));
        Console.WriteLine(milesToFeetConverter.converter(10));
        Console.ReadKey();
        //
    }
}