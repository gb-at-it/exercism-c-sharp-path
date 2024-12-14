

var prePopulated = DialingCodes.GetExistingDictionary();
Console.WriteLine(prePopulated.Count);

var prePopulated2 = DialingCodes.GetExistingDictionary();
Console.WriteLine(prePopulated2[91]);

var countryCodes = DialingCodes.AddCountryToExistingDictionary(DialingCodes.GetExistingDictionary(), 44, "United Kingdom");
Console.WriteLine(countryCodes.Count);
