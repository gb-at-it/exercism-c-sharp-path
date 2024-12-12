using System;
using System.Linq;

namespace Birds;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
        => [0, 2, 5, 3, 7, 8, 4];

    public int Today()
        => birdsPerDay.Last();

    public void IncrementTodaysCount()
        => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    {
        foreach (var day in birdsPerDay)
        {
            if (day == 0)
                return true;
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int count = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            count += birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        int count = 0;
        foreach (var day in birdsPerDay)
        {
            if (day > 4)
                count++;
        }
        return count;
    }
}

class BirdCount2
{
    private int[] birdsPerDay;

    public BirdCount2(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
        => [0, 2, 5, 3, 7, 8, 4];

    public int Today()
        => birdsPerDay.Last();

    public void IncrementTodaysCount()
        => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
        => birdsPerDay.Contains(0);

    public int CountForFirstDays(int numberOfDays)
        => birdsPerDay.Take(numberOfDays).Sum();

    public int BusyDays()
        => birdsPerDay.Where(day => day > 4).Count();
}