﻿using System.Text;

static string Count(List<string> input)
{
    Dictionary<char, int> charCount = input.SelectMany(s => s)
        .GroupBy(c => c)
        .ToDictionary(g => g.Key, g => g.Count());

    StringBuilder sb = new();

    foreach (KeyValuePair<char, int> pair in charCount)
    {
        sb.AppendLine($"{pair.Key} -> {pair.Value}");
    }

    return sb.ToString().Trim();
}

List<string> input= new List<string>() {"new","sofia","@" };
string result=Count(input);
Console.WriteLine(string.Join(",",result));
