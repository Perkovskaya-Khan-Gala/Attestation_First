// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна три символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int GetNumber(string message)
{
    int result=0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result)&& result>0) break;
        else Console.WriteLine("Введено не число или число меньшее или равно нулю. Попробуйте еще раз");
    }
    return result;
}

string[] FillArray(int size)
{
    string[] arrayNew=new string[size];
    for (int i = 0; i < size; i++)
    {
        arrayNew[i]=Console.ReadLine();
    } 
    return arrayNew;
}

int FindQuantityOfElements(string[] array)
{
    string stroka=string.Empty;
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        stroka=array[i];
        if (stroka.Length<=3) count++;
    }
    return count;
}
string[] ComponateResultArray(string[] array, int size)
{
    string[] arrayNew=new string[size];
    string stroka=string.Empty;
    int count=0;
    for (int i = 0; i < array.Length; i++)
    {
        stroka=array[i];
        if (stroka.Length<=3) 
        {
            arrayNew[count]=array[i];
            count++;
        }
    }
    return arrayNew;
}

void ShowArrays(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}

int arraySize=GetNumber("Введите размер массива:");
Console.WriteLine("Введите элементы массива через Enter");
string[] arrayToFill=FillArray(arraySize);
int sizeResultArray=FindQuantityOfElements(arrayToFill);
string[] arrayResult=ComponateResultArray(arrayToFill, sizeResultArray);
ShowArrays(arrayToFill);
Console.Write(" -> ");
ShowArrays(arrayResult);
