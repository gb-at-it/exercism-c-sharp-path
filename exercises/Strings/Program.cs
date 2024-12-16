// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine(Identifier.Clean0("Hello, World!"));
Console.WriteLine(Identifier.Clean1("Hello, World!"));
Console.WriteLine(Identifier.Clean2("Hello, World!"));
Console.WriteLine(Identifier.Clean("my\0Id"));
Console.WriteLine(Identifier.Clean("à-ḃç"));
Console.WriteLine(Identifier.Clean("1😀2😀3😀"));
Console.WriteLine(Identifier.Clean("MyΟβιεγτFinder"));

