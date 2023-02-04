int[] array = { 17, 22, 13, 4, 85, 68, 57, 85, 19 };

int n = array.Length;
int find = 85;
int index = 0;

while (index < n)
{
  if (array[index] == find)
  {
    Console.WriteLine(index);
    break;
  }
  index++;
}