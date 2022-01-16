using System;

string datetime = DateTime.Now.ToString("HH:mm:ss tt");
Console.WriteLine("A hora atual é : "+datetime);

Double epoch = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;

Console.WriteLine(epoch);