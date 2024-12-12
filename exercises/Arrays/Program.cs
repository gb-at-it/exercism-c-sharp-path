using Birds;

int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
var birdCount = new BirdCount(birdsPerDay);
var birdCountToday = birdCount.Today();
Console.WriteLine(birdCountToday);
Console.WriteLine(birdsPerDay[^1]);
