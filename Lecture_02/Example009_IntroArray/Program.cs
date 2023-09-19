int Max(int arg1, int arg2, int arg3)
{
    int res = arg1;
    if (arg2 > res) res = arg2;
    if (arg3 > res) res = arg3;
    return res;
}

int[] array = {1, 34, 22, 75, 34, 22, 95, 11, 1};



int max = Max(Max(array[0], array[1], array[2]),
              Max(array[3], array[4], array[5]),
              Max(array[6], array[7], array[8]));

Console.WriteLine(max);