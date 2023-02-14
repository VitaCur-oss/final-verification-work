using static System.Console;
Clear();

string[] array = {"Hello", "2", "world", ":-)"};
// string[] array1 = {"1234", "1567", "-2", "computer science"};
// string[] array2 = {"Russia", "Denmark", "Kazan"};
int b = LenghtNewArray(array);
string[] newarray = NewArray(array, b);
PrintArray(array);
Write(" -> ");
PrintArray(newarray);

int LenghtNewArray(string[] getarr)
{
    int result = 0;
    for (int i = 0; i < getarr.Length; i++)
    {
        if (getarr[i].Length <= 3) result++;
    }
    return result;
}
       
string[] NewArray(string[] arr, int size)
{
    string[] resultarray = new string[size];
    int c = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3){ resultarray[c] = arr[i]; c++;}
    }
    return resultarray;
}


void PrintArray(string[] prarr)
{
    if (prarr.Length > 0) {
        Write("[");
        for (int i = 0; i < prarr.Length - 1; i++)
        {
            Write($"'{prarr[i]}', ");
        }
        Write($"'{prarr[prarr.Length - 1]}']");}
    else Write("[]");
}

