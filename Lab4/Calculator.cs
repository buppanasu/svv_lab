public class Calculator
{
    public double GenMagicNum(double input)
    {
        double result = 0;
        int choice = Convert.ToInt16(input);
        // Dependency------------------------------
        FileReader getTheMagic = new FileReader();
        //----------------------------------------
        string[] magicStrings = getTheMagic.Read("MagicNumbers.txt");
        if ((choice >= 0) && (choice < magicStrings.Length))
        {
            result = Convert.ToDouble(magicStrings[choice]);
        }
        result = (result > 0) ? (2 * result) : (-2 * result);
        return result;
    }
}
