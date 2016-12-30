<Query Kind="Program" />

void Main()
{
	var stringTest = "AaZz";
	CustomShiftCipher.ShiftString(stringTest, 100).Dump();
}

public static class CustomShiftCipher
{
	public static string ShiftString(string stringToShift, int cipherKey)
	{
		var shiftedString = "";
		
		foreach(var charToShift in stringToShift)
		{
			shiftedString += ShiftChar(charToShift, cipherKey);
		}
		
		return shiftedString;
	}
	
	private static char ShiftChar(char charToShift, int cipherKey)
	{
	    cipherKey %= 26;
		cipherKey.Dump();
		if(cipherKey < 0)
		{
		  	cipherKey += 26;
		}
		var charAsInt = (int)charToShift;
		if(charAsInt >= 97)
		{
			charAsInt -= 97;
			charAsInt += cipherKey;
			charAsInt %= 26;
			charAsInt += 97;
		}
		else
		{
			charAsInt -= 65;
			charAsInt += cipherKey;
			charAsInt %= 26;
			charAsInt += 65;
		}
		
		return (char)charAsInt;
	}
}