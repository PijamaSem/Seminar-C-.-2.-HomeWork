// Seminar #2. Home work. Alexeev Andrey.

// Task #10. Write program witch take 2 numerics and output 2nd digit
/*
int SecondDigit(int num){
    int dig12 = num / 10;
    int dig2 =  dig12 % 10;
    return dig2;
}
Console.WriteLine("Pls enter numerics over 99 and less 1000");
int a = Convert.ToInt32(Console.ReadLine());
int result = SecondDigit(a);
Console.WriteLine($"Second digit of numeris is {result}");*/

// Task #13 Write program witch out 3rd digit of input numeric or test "Numeric haven't 3rd digit
/*
int ThirdDigit(int num){
    int digMore3Digit = num / 100;
    int dig3 =  digMore3Digit % 10;
    return dig3;
}
Console.WriteLine("Pls enter numerics");
int a = Convert.ToInt32(Console.ReadLine());
if (a<100){
    Console.WriteLine($"nummeric less 100");
}else{
    Console.WriteLine($"Third digit of numeric is {ThirdDigit(a)}");
}*/

//Task #15. Write program witch take number representing the day of the week and check it's weekend or not.

void Week(int a){
    if (a<1 || a>7) {
    Console.WriteLine($"Input data `{a}`  error. pls read calendar manual");
} else {
    if (a<6){
        Console.WriteLine("NO");    
    }else{
        Console.WriteLine("YES");
    }
 }
}
Console.WriteLine("Pls enter number representing the day of the week:");
int a = Convert.ToInt32(Console.ReadLine());
Week(a);