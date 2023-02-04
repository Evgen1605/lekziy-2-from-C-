int Maximum(int arg1, int arg2, int arg3)
{
  int result = arg1;
  if (arg2 >result){result = arg2;}
  if (arg3 > result){result = arg3;}
  return result;
}

int a1 = 235656, b1 = 3478, c1 = 45;
int a2 = 632, b2 = 64, c2 = 48;
int a3 = 78, b3 = 85459, c3 = 56;

// int Max1 = Maximum(a1, b1, c1);
// int Max2 = Maximum(a2, b2, c2);
// int Max3 = Maximum(a3, b3, c3);
// int max = Maximum(Max1, Max2, Max3);

int max = Maximum(
  Maximum(a1, b1, c1),
  Maximum(a2, b2, c2),
  Maximum(a3, b3, c3)
);

Console.Clear();
Console.WriteLine(max);
