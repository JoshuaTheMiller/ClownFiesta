<Query Kind="Program" />

void Main()
{
	var stringTest = "Hello";
	var encryptedTest = "Mjqqt";
	CustomShiftCipher.ShiftString(stringTest, -10);
	CustomShiftCipher.ListSolutions(encryptedTest);
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
	
	// Lists all 26 possible solutions to shiftCipher in console
	public static string ListSolutions(string encryptedString)
	{
		List<string> solutions = new List<string>();
		for (var i = 0; i < 26; i++)
		{
			solutions.Add(ShiftString(encryptedString, i));
			Console.WriteLine(i + " " + solutions[i]);
		}
		return "";
	}
	
	private static char ShiftChar(char charToShift, int cipherKey)
	{
	    cipherKey %= 26;
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