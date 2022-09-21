Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] arrayInput = new string[n];
for (int i = 0; i < n; i++) {
    Console.WriteLine($"Введите {i + 1}-й элемент: ");
    arrayInput[i] = Console.ReadLine();    
}

string[] arrayOut = new string[n];
int size = 3;
int m = 0;
for (int j = 0; j < n; j++) {
    if (arrayInput[j].Length <= size) {
    arrayOut[m] = arrayInput[j];
    m++;
    }
}

PrintArray(arrayOut);

void PrintArray(string[] array) {
    Console.Write("Массив из строк, длина которых меньше либо равна 3 символа: ");
    for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
    if (m == 0) Console.Write("нет массива");
    Console.WriteLine();
}
