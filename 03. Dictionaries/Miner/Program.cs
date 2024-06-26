﻿
using System.Text;

static string Mine(params string[] input)
{
    Dictionary<string, int> resources = new();

    foreach (string s in input)
    {
        string[] split = s.Split();

        resources.TryAdd(split[0].ToLower(), 0);
        resources[split[0].ToLower()] += int.Parse(split[1]);
    }

    StringBuilder sb = new();

    foreach (KeyValuePair<string, int> pair in resources)
    {
        sb.AppendLine($"{pair.Key} -> {pair.Value}");
    }

    return sb.ToString().Trim();
}

string[] input = {"Gold\n10","silver\n150\n"};
string result = Mine(input);
Console.WriteLine(string.Join(",",result));

