string[] array = { "hello", "2", "world", ":-)" };

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}

string[] resultArray = new string[count];

int step = 0;
for (int i = 0; i < array.Length; i++)
{
    int temp = step;
    if (array[i].Length <= 3) step++;
    if (temp != step) resultArray[step-1] = array[i];
}