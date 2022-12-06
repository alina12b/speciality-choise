string[] CreateArr() {
    Console.WriteLine("Введите количество строк, которые хотите ввести: ");
    int length = Convert.ToInt32(Console.ReadLine());
    string[] arr = new string[length];
    int i = 0;

    Console.WriteLine("Введите же ваши строки: ");
    while (i < length) {
        arr[i] = Console.ReadLine();
        i++;
    }

    return arr;
}

string[] SortArr(string[] arr) {
    string[] sortedArr = new string[arr.Length];
    int i = 0; 
    int j = 0;
    Console.WriteLine("Оставшиеся строки:");

    while (i < arr.Length) {
        if (arr[i].Length <= 3) {
            sortedArr[j] = arr[i];
            Console.Write($"{sortedArr[j]} ");
            j++;
        }
        i++;
    }

    return sortedArr;
}

string[] arr = CreateArr();
string[] sortedArr = SortArr(arr);