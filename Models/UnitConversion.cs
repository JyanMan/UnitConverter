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
            case "foot":
                float footToM = value * 0.3048f;
                newValue = FromMeterConvert(footToM, funit);
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

    public static string ConvertWeight(float value, string iunit, string funit)
    {
        float newValue = value;
        switch (iunit)
        {
            case "gram":
                newValue = FromGramConvert(value, funit);
                break;
            case "milligram":
                float mgToG = value * 0.001f;
                newValue = FromGramConvert(mgToG, funit);
                break;
            case "kilogram":
                float kgToG = value * 1000f;
                newValue = FromGramConvert(kgToG, funit);
                break;
            case "ounce":
                float oToG = value * 28.3495f;
                newValue = FromGramConvert(oToG, funit);
                break;
            case "pound":
                float pToG = value * 453.592f;
                newValue = FromGramConvert(pToG, funit);
                break;
            default:
                break;

        }
        return $"{newValue} {funit}";
    }

    static float FromGramConvert(float value, string unit)
    {
        switch (unit)
        {
            case "milligram":
                return value * 1000f;
            case "kilogram":
                return value * 0.001f;
            case "ounce":
                return value * 0.035274f;
            case "pound":
                return value * 0.00220462f;
            default:
                break;
        }

        return value;
    }

    public static string ConvertTemp(float value, string iunit, string funit)
    {
        float newValue = value;
        switch (iunit)
        {
            case "celsius":
                if (funit == "fahrenheit")
                    newValue = (value * 9 / 5) + 32;
                else if (funit == "kelvin")
                    newValue = value + 273.5f;
                break;
            case "fahrenheit":
                if (funit == "celsius")
                    newValue = (value - 32) * 9 / 5;
                else if (funit == "kelvin")
                    newValue = ((value - 32) * 9 / 5) + 273.5f;
                break;
            case "kelvin":
                if (funit == "celsius")
                    newValue = value - 273.5f;
                break;
            default:
                break;
        }
        string result = $"{newValue} {funit}";
        return result;
    }
}
