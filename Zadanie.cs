Console.WriteLine($"Задайте размерность массива");
string[] newArray = new string [int.Parse(Console.ReadLine()!)];
int numberRow = 1;
for (int limit = 0; limit < newArray.Length; limit++){
    Console.WriteLine($"Введите {numberRow} строку из {newArray.Length}");
    string row = (Console.ReadLine()!);
    newArray[limit] = row;
}
// Console.WriteLine($"исходный массив: [{String.Join(", ", newArray)}]");
CutRowInArray(newArray);

//Вариант 1. 
void CutRowInArray(string[] array){
    int count = 0;
    string temp = String.Empty;
    for (int limit = 0; limit < array.Length; limit++){
        if (array[limit].Length <= 3){
            temp = temp + array[limit] + " ";
            count++;
        }
    }
    string[] result = temp.Split(" ", count, StringSplitOptions.RemoveEmptyEntries);
    Console.WriteLine($" [{String.Join(", ", result)}]");
}   


//Вариант 2 (Хуже)
// void CutRowInArray(string[] array){
//     string[] result = new string [array.Length];
//     int count = 0;
//     for (int limit = 0; limit < array.Length; limit++){
//             if (array[limit].Length <= 3){
//             result[limit] = array[limit];
//             count++;
//         }
//     }
//     if (count > 0) Console.WriteLine($" [{String.Join(" , ", result)}]");  
//     else Console.WriteLine("[]");                                               
// }


    


