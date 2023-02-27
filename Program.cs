string[] array = { "hello", "2", "world", ":-)" };

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}