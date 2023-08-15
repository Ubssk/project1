Console.Write("Введите массив строк (в кавычках через пробел): ");
string enter = Console.ReadLine();
string[] StartArray = enter.Split(new char[] {' '}); 
// Разделение элементов строки в массив
int length = 3; // Параметр длины элемента первого массива
string[] WithoutQuotesArray = StartArray.Select(str => str.Replace("\"", "")).ToArray();
// Убираем кавычки из элементов массива
string[] FinishArray = WithoutQuotesArray.Where(str => str.Length <= length).ToArray();
// Вывод элементов нового массива
Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам: ");
for (int i = 0; i < FinishArray.Length; i++)
{
    Console.Write(FinishArray[i] + " "); // печать итогового массива
}