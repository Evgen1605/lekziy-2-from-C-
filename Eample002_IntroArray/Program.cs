﻿int Maximum(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 > result) { result = arg2; }
  if (arg3 > result) { result = arg3; }
  return result;
}

int[] array = { 51, 32, 31, 547, 53, 687, 71, 84, 19 };

int max = Maximum(
  Maximum(array[0], array[1], array[2]),
  Maximum(array[3], array[4], array[5]),
  Maximum(array[6], array[7], array[8])
);

Console.Clear();
Console.WriteLine(max);
