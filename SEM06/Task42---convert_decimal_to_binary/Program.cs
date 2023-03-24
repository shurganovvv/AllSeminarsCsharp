// Задача 42: Напишите программу, которая 
//     будет преобразовывать десятичное число в двоичное.
//         44 -> 101100
//         3  -> 11
//         2  -> 10

int WriteTxtReadToInt32(string txt){
    System.Console.Write(txt);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array) {
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

void GetBinaryView(int convert) {
    if (convert <= 1) 
        return;
    // System.Console.Write(convert%2);    //вывод до рекурсии
    GetBinaryView(convert/2);
    System.Console.Write(convert%2); 
    //вывод происходит последовотельно после рекурсии, 
        // а значит, начиная с последней операции двигаясь к первой
/* НО рекурсия имеет ограниченную память стека, а значит, очень большое кол-во операций (по вызову сомой себя) приведёт к ошибке */
}

int[] ConvertDecimalToBinary (int convertible) {
    int size = 0;
    int temp = convertible;
    while (temp >= 1) {
        temp /= 2;
        size++;
    }
    
    int[] converted = new int[size];
    for (int i = 0; i < size; i++) {
        converted[i] = convertible % 2;
        convertible /= 2;
    }

    // Array.Reverse(resalt);   // перевернёт массив как и цикл ниже
    for (int i = 0; i < size/2; i++) {
        temp = converted[i];
        converted[i] = converted[converted.Length - i-1];
        converted[converted.Length - i-1] = temp;
    }
    
    return converted;
}

int accepted = WriteTxtReadToInt32("дай 'десятку': ");
System.Console.WriteLine("тупо готовый конверт: " + Convert.ToString(accepted, 2));

System.Console.Write("а всё-таки Рекурсия - это Сила: ");
GetBinaryView(accepted);
System.Console.WriteLine();

int acceptedForArray = accepted;
int[] resalt = ConvertDecimalToBinary(acceptedForArray); //мой массив
PrintArray(resalt); // можно правит функцию, чтоб выводила без разделителя

string forBinary = "";  //строка с семинара, конечно, проще
while (accepted >= 1) {
        forBinary += accepted % 2;
        accepted /= 2;
    }
for (int i = forBinary.Length-1; i >= 0; i--) {
    System.Console.Write(forBinary[i]);
}
System.Console.WriteLine();