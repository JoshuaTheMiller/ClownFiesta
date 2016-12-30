<Query Kind="Program" />

void Main()
{
	var stringToEncrypt = "aaazz";
	var cipherKey = -2;
	
	var encryptedString = SecurityTests.Encrypt(stringToEncrypt, cipherKey);
	
	encryptedString.Dump();
	
}

// Define other methods and classes here

public static class SecurityTests
{
	static string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
	
	public static string Encrypt(string stringToEncrypt, int cipherKey)
	{
	
		string output = "";
		stringToEncrypt = stringToEncrypt.ToUpper();
		
		for (var i = 0; i < stringToEncrypt.Length; i++ )
		{
		
			for (var n = 0; n < alphabet.Length; n++ )
			{
			
				// if character matches letter in alphabet
				if (stringToEncrypt[i] == alphabet[n])
				{
				
					// handle index less than zero
					if (n + cipherKey < 0)
					{
						output += alphabet[26+cipherKey];
					}
					
					// handle index greater than 25
					else if (n + cipherKey > 25)
					{
						output += alphabet[-1+cipherKey];
					}
					
					else 
					{
				
						output += alphabet[n+cipherKey];
					}
					
				}
			}
			
   			
		}
		
		return output;
	}
}