string? input = "a";
Console.WriteLine("Введите количество строк в массиве: ");
input = Console.ReadLine();
int len = 0;
while (len <= 0){
    if (int.TryParse(input, out len) & len > 0){
    Console.WriteLine("Отлично!");
    
    }
    else {
    Console.WriteLine("Неверный ввод! Введите число больше нуля!");
    input = Console.ReadLine();
    }
}
string[] arr = new string[len];
int num = 0;
for (int i = 0; i < len; i++){
    Console.WriteLine($"Элемент массива {i + 1}: ");
    arr[i] = Console.ReadLine();
    if (arr[i].Length < 4){num ++;}
}

Console.WriteLine($"[{string.Join(", ", arr)}]");
//Console.WriteLine($"Количество элементов меньше 4 равно {num}");
string[] out_arr = new string[num];
int j =0;

for (int i=0; i < len; i++) {
    if (arr[i].Length <4){out_arr[j] = arr[i]; j++;}

}
Console.WriteLine("Новый массив, содержащий элементы короче 4 символов:");
Console.WriteLine($"[{string.Join(", ", out_arr)}]");