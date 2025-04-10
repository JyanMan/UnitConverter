namespace UnitConverter.Models;
public class UnitConversion
{
    public UnitConversion() {}

    public static string ConvertLength(float value, string iunit, string funit)
    {
        float newValue = value;
        switch (iunit)
        {
            //convert first to meter, then from meter to the final unit
            case "millimeter":
                float mmToM = value * 0.001f;
                newValue = FromMeterConvert(mmToM, funit);
                break;
            case "centimeter":
                float cmToM = value * 0.01f;
                newValue = FromMeterConvert(cmToM, funit);
                break;
            case "meter":
                newValue = FromMeterConvert(value, funit);
                break;
            case "kilometer":
                float kmToM = value * 1000f;
                newValue = FromMeterConvert(kmToM, funit);
                break;
            case "inch":
                float inchToM = value * 0.0254f;
                newValue = FromMeterConvert(inchToM, funit);
                break;
            case "yard":
                float yardToM = value * 0.9144f;
                newValue = FromMeterConvert(yardToM, funit);
                break;
            case "mile":
                float mileToM = value * 1609.34f;
                newValue = FromMeterConvert(mileToM, funit);
                break;
            default:
                break;
        }
        string result = $"{newValue} {funit}";
        return result;
    }

    static float FromMeterConvert(float value, string unit)
    {
        switch (unit)
        {
            case "millimeter":
                return value * 1000f;
            case "centimeter":
                return value * 100f;
            case "kilometer":
                return value * 0.001f;
            case "foot":
                return value * 3.28084f;
            case "yard":
                return value * 1.09361f;
            case "mile":
                return value * 0.000621371f;
            case "inch":
                return value * 39.3701f;
            default:
                break;
        }
        return value;
    }

    public static string ConvertWeight()
    {
        string result = "";
        return result;
    }
}
