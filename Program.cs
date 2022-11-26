

Console.Clear();

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

while (true)
{

Console.Clear();
Console.Write("Укажите, какое количество элементов будем использовать: "); 
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1}-й элемент: "); string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int len = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= len)
    {
        arrayFinal[pos] = arrayStrings[j]+';';
        pos++;
    }
}

Console.WriteLine("-------------------------------------------------------------------------");
Console.Write("Элементы, длина которых меньше либо равна 3 символа: ");
PrintArray(arrayFinal);

Console.WriteLine("");
Console.WriteLine("########################################################################");
Console.WriteLine("Если хотите повторить нажмите Enter, для выхода введите любой символ.");


string answ = Console.ReadLine();
if (!String.IsNullOrEmpty(answ))
    break;
}

//Знаю, что надо бы добавить проверку на ввод пустого значения или менее одного элемента надо бы добавить, но я не знаю как. 
//Изучу дополнительно, как будет время, самостоятельно.
