using System.Text;

const int NumberOfValues = 5;
int[] numbers1 = new int[NumberOfValues];
int[] numbers2 = new int[NumberOfValues];
int[] sums = new int[NumberOfValues];
Random rnd = new Random();

// Random initialisatie
for (int i = 0; i < numbers1.Length; i++)
    numbers1[i] = rnd.Next(11);

for (int i = 0; i < numbers2.Length; i++)
    numbers2[i] = rnd.Next(11);

// Berekening van sommen
for (int i = 0; i < sums.Length; i++)
    sums[i] = numbers1[i] + numbers2[i];

// Bouw de resultererende string op via StringBuilder
// en toon het resultaat.
StringBuilder builder = new StringBuilder();
builder.AppendLine("=== Som maken van getallen uit 2 arrays ====\r\n\r\n");
builder.Append("Array 1 ==>");
foreach (int number in numbers1)
    builder.Append($"{number,6}");
builder.AppendLine();

builder.Append("Array 2 ==>");
foreach (int number in numbers2)
    builder.Append($"{number,6}");
builder.AppendLine();

builder.Append("Array 3 ==>");
foreach (int getal in sums)
    builder.Append($"{getal,6}");
builder.AppendLine();

Console.Write(builder.ToString());
Console.ReadLine();