var newList = Languages.NewList();
newList.Add("ciao");
Console.WriteLine(newList[^1]);

var languageList = Languages.GetExistingLanguages();
languageList.ForEach(Console.WriteLine);