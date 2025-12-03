using System;
namespace AppDev.Week_4{
// 1. Enum for DayType
enum DayType
{
    Weekday,
    Weekend
}

// 2. Record for Book
record Book(string title, string author, double price);
}