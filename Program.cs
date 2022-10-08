////Функция выводит цифру по заданной позиции из числа
///Подходит для первых двух задач
int GetNumberByPosition(int number, int position)
{
    if (number<Math.Pow(10,position-1) || position <= 0)
    {
        Console.Write("Нет цифры на позиции ");
        return position;
    }
    while(number > Math.Pow(10,position))
    {
        number/=10;
    }
    return number == 10 ? 1 : number%10;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.Write("Введите позицию числа: ");
int position = int.Parse(Console.ReadLine());
Console.WriteLine(GetNumberByPosition(number,position));

//////////////////////Задача номер 15
string isWeekend(int day)
{
    if(day == 6 || day == 7)
    {
        return "Это выходной";
    }
    else if(day > 0 && day < 6)
    {
        return "Будний день";
    }
    else return "Нет такого дня недели.";
}
Console.Write("Введите номер дня недели: ");
int day = int.Parse(Console.ReadLine());
Console.WriteLine(isWeekend(day));


/////////////////Дополнительная задача

//Заполняет массив заданной размерности случайными числами
int [] FillArray(int len, int [] arr)
{
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(10,21);
    }
    return arr;
}

//печатает массив любой размерности
void PrintArray(int [] arr)
{
    foreach(int i in arr)
    {
        Console.Write(i + " ");
    }
}

//выводит массив в обратном порядке
void PrintArrayInverse(int [] arr)
{
    for(int i = arr.Length-1; i >= 0; i--)
    {
        Console.Write(arr[i] + " ");
    }
}

////удаляет элементы со значением 20 из массива чисел
int [] FilterArray(int [] arr)
{
    int counter = 0;
    foreach(int i in arr)
    {
        if(i==20)
            counter ++;
    }

    int [] NewArr = new int [arr.Length - counter];
    int j = 0;

    for(int i = 0; i<arr.Length; i ++)
    {
        if(arr[i]!=20)
        {
            NewArr[j] = arr[i];
            j++;
        }        
    } 
    return NewArr;
}

Console.Write("Введите размерность массива: ");
int len = int.Parse(Console.ReadLine());
int [] arr = new int [len];
arr = FillArray(len, arr);
Console.Write("Исходный массив: ");
PrintArray(arr);
int [] NewArr = FilterArray(arr);
Console.WriteLine();
Console.Write("Результирующий массив: ");
PrintArrayInverse(NewArr);
