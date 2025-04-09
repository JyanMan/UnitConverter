
namespace UnitConverter.Models;
public class UnitConversion
{
    public UnitConversion() {}

    public static float ConvertLength(float value, string iunit, string funit)
    {
        switch (iunit)
        {
            case "cm":
                if (funit == "m")
                {
                    return value / 100;
                }
                break;
            default:
                break;
        }

        return 0;
    }
}