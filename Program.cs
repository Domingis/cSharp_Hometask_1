//  Первая задача //
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());
// if (num1 > num2){
//     Console.WriteLine("Наибольшое число " + num1);
// }
// else{
//      Console.WriteLine("Наибольшое число " + num2);
// }
//Вторая задача//
// Console.Write("Введите первое число: ");
// int num1 = int.Parse(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = int.Parse(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = int.Parse(Console.ReadLine());
// if (num1 > num2){
//     if(num1 > num3){
//         Console.WriteLine("Наибольшое число " + num1);
//     }
//     else{
//         Console.WriteLine("Наибольшое число " + num3);
//     }
// }
// else if(num2 > num3){
//     Console.WriteLine("Наибольшое число " + num2);
// }
// else {
//     Console.WriteLine("Наибольшое число " + num3);
// }

//Третья задача//
// Console.Write("Введите число ");
// int number = int.Parse(Console.ReadLine());
// int a = number % 2;
// if (number % 2 == 0){
//     Console.WriteLine("Ваше число чётное");
// }
// else{
//     Console.WriteLine("Ваше число нечётное");
// }

//Четвёртая задача//
Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());
int i = 2;
while (i <= number){
    Console.WriteLine(i);
    i+=2;
}