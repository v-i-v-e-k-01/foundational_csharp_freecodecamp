﻿using System;
Random random = new Random();
string[] pettingZoo =
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese",
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws",
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};


PlanSchoolVisit("School A");
PlanSchoolVisit("School B",3);
PlanSchoolVisit("School C",2);

void PlanSchoolVisit(string schoolName, int groups=6)
{
    RandomizeAnimals();
    string[,] group=AssignGroup(groups);
    Console.WriteLine(schoolName);  
    PrintGroup(group);
}

void RandomizeAnimals()
{
    for (int i = 0; i < pettingZoo.Length; i++)
    {
        int r = random.Next(pettingZoo.Length);
        
        string temp = pettingZoo[i];
        pettingZoo[i] = pettingZoo[r];
        pettingZoo[r] = temp;
    }

}

string[,] AssignGroup(int groups = 6)
{
    int groupSize = pettingZoo.Length / groups;
    string[,] result = new string[groups, groupSize];
    int start = 0;

    for (int i = 0; i < groups; i++)
    {
        for (int j = 0; j < groupSize; j++)
        {
            result[i, j] = pettingZoo[start++];
        }
    }

    return result;
}


void PrintGroup(string[,] group)
{
    for (int i = 0; i < group.GetLength(0); i++)
    {
        Console.Write($"Group{i+1}: ");
        for (int j = 0; j < group.GetLength(1); j++)
        {
            Console.Write($"{group[i, j]} ");
        }
        Console.WriteLine();
    }
}

// foreach(var str in pettingZoo)
// {
//     Console.WriteLine(str);
// }


