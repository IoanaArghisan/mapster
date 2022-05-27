public class KeyConverter
{
    public static int getIdFromKey(string key)
    {
        switch (key)
        {
            case ("highway"):
                return 0;
            case ("waterway"):
                return 1;
            case ("railway"):
                return 2;
            case ("natural"):
                return 3;
            case ("boundary"):
                return 4;
            case ("landuse"):
                return 5;
            case ("building"):
                return 6;
            case ("leisure"):
                return 7;
            case ("amenity"):
                return 8;
            case ("admin_level"):
                return 9;
            case ("place"):
                return 10;
            case ("name"):
                return 11;
            
            default:
                return 255;
        }
    }
}