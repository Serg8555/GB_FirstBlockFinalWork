﻿string[] names1 = new string[] {"Ted", "Alex", "Sam", "Simon", "Johson"};
string[] names2 = new string[names1.Length];
void ShortNames(string[] names1, string[] names2)
    {
    int count = 0;
    for (int i = 0; i < names1.Length; i++)
        {
        if(names1[i].Length <= 3)
            {
            names2[count] = names1[i];
            count++;
            }
        }
    }
void PrintNames(string[] names)
    {
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{names[i]} ");
        }
        Console.WriteLine();
    }
ShortNames(names1, names2);
PrintNames(names2);