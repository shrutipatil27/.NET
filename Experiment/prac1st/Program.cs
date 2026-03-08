using System;

Console.WriteLine("Hello, World from demo2!");
Console.WriteLine("im learning c#");
Console.WriteLine("im begginer");
Console.WriteLine(3 + 3);

//Create a variable called name of type string and assign it the value "Alice"
string name = "Alice";
Console.WriteLine(name);

//Create a variable called myNum of type int and assign it the value 15
int myNum = 15;
Console.WriteLine(myNum);

//Change the value of myNum 20 to 30
int myNum2 = 20;
myNum2 = 30;//myNum2 is now 30
Console.WriteLine(myNum2);// output 30


int myNum3 = 5;
double myDoubleNum3 = 5.99D;
char myLetter3 = 'D';
bool myBool3 = true;
string myText3 = "Hello";
Console.WriteLine(myNum3);
Console.WriteLine(myDoubleNum3);
Console.WriteLine(myLetter3);
Console.WriteLine(myBool3);
Console.WriteLine(myText3);

//string name2 = "John";
//Console.WriteLine("Hello " + name2)//output Hello John


//string firstName = "John ";
//string lastName = "Doe";
//string fullName = firstName + lastName;
//Console.WriteLine(fullName);//output JohnDoe

int x = 5;
int y = 10;
Console.WriteLine(x + y);//output 15

int a = 10, b = 20, c = 30;
Console.WriteLine(a + b + c);//output 60


int d, e, f;
d = e = f = 50;
Console.WriteLine(d + e + f);//output 150

float myNum4 = 5.75F;
Console.WriteLine(myNum4);//output 5.75

float f1 = 35e3F;
float d1 = 12E4F;
Console.WriteLine(d1);
Console.WriteLine(f1);

//BOOLEANS
bool isCSharpFun = true;
bool isFishTasty = false;
Console.WriteLine(isCSharpFun);//output true
Console.WriteLine(isFishTasty);//output false

//CHARACTERS
char myGrade = 'A';
Console.WriteLine(myGrade);//output A

//TYPE CASTING

//implicit casting (automatically) - converting a smaller type to a larger type size
int myInt = 9;
double myDouble = myInt; // Automatic casting: int to double
Console.WriteLine(myInt);//output 9
Console.WriteLine(myDouble);//output 9


//explicit casting (manually) - converting a larger type to a smaller size type
double myDouble2 = 9.78;
int myInt2 = (int)myDouble2; // Manual casting: double to int
Console.WriteLine(myInt2);//output 9
Console.WriteLine(myDouble2);//output 9.78

//type conversion methods
int myInt3 = 10;
double myDouble3 = 5.25;
bool myBool = true;
Console.WriteLine(Convert.ToString(myInt3));//convert int to string
Console.WriteLine(Convert.ToDouble(myInt3));//convert int to double
Console.WriteLine(Convert.ToInt32(myDouble3));//convert double to int
Console.WriteLine(Convert.ToString(myBool));//convert bool to string


//GETTING INPUT FROM THE USER

//Console.WriteLine("Enter your name: ");
//string userName = Console.ReadLine();
//Console.WriteLine("Username is:" + userName);


//OPERATORS
int sum1 = 100 + 50;       // 150 (100 + 50)
int sum2 = sum1 + 250;    // 400 (150 + 250)
int sum3 = sum2 + sum2;   // 800 (400 + 400)
Console.WriteLine(sum1);//output 150
Console.WriteLine(sum2);//output 400
Console.WriteLine(sum3);//output 800


//ASSIGNMENT OPERATORS
//addition assignment
int z = 10;
z += 5; // z = z + 5
Console.WriteLine(z);//output 15

//subtraction assignment
int w = 10;
w -= 5; // w = w - 5
Console.WriteLine(w);//output 5

//multiplication assignment
int v = 10;
v *= 5; // v = v * 5
Console.WriteLine(v);//output 50

//division assignment
int u = 10;
u /= 5; // u = u / 5
Console.WriteLine(u);//output 2

//modulus assignment
int t = 10;
t %= 3; // t = t % 3
Console.WriteLine(t);//output 1

//bitwise AND assignment
int p = 5;
p &= 3; // p = p & 3
Console.WriteLine(p);//output 1

//bitwise OR assignment
int q = 5;
q |= 3; // q = q | 3
Console.WriteLine(q);//output 7

//bitwise XOR assignment
int r = 5;
r ^= 3; // r = r ^ 3
Console.WriteLine(r);//output 6

//right shift assignment
int s = 5;
s >>= 1; // s = s >> 1
Console.WriteLine(s);//output 2

//left shift assignment
int i = 5;
i <<= 1; // i = i << 1
Console.WriteLine(i);//output 10

//COMPARISON OPERATORS
int j = 5;
int k = 10;
Console.WriteLine(j > k);//output False because 5 is not greater than 10

//eqal to
int l = 5;
int m = 5;
Console.WriteLine(l==m);//output True

//not equal to
int n = 5;
int o = 10;
Console.WriteLine(n!=o);//output True because 5 is not equal to 10

//greater than
int aa = 10;
int bb = 5;
Console.WriteLine(aa>bb);//output True because 10 is greater than 5

//less than
int cc = 5;
int dd = 10;
Console.WriteLine(cc<dd);//output True because 5 is less than 10

//greater than or equal to
int ee = 10;
int ff = 10;
Console.WriteLine(ee>=ff);//output True because 10 is equal to 10

//less than or equal to
int gf = 10;
int hg = 15;
Console.WriteLine(hg<=gf);//output False because 15 is not less than or equal to 10

//LOGICAL OPERATORS

//AND operator
int xx = 10;
Console.WriteLine(xx > 5 && xx < 15);//output True because both conditions are true

//OR operator
int yy = 10;
Console.WriteLine(yy > 5 || yy < 5);//output True because one of the conditions is true

//NOT operator
int zz = 10;
Console.WriteLine(!(zz > 5 && zz < 15));//output False because the condition is true but NOT operator negates it


//MATH METHODS
//max method
Console.WriteLine(Math.Max(5, 10));//output 10

//min method
Console.WriteLine(Math.Min(5, 10));//output 5

//sqrt method
int zz2 = 64;
Console.WriteLine(Math.Sqrt(zz2));//output 8


//STRINGS

string greeting = "Hello";
Console.WriteLine(greeting);

string greeting2 = "nice to meet you";
Console.WriteLine(greeting2);

string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("The length of the txt string is: " + txt.Length);//output The length of the txt string is: 26

string st1 = "Hello World";
Console.WriteLine(st1.ToUpper());   // Outputs "HELLO WORLD"
Console.WriteLine(st1.ToLower());   // Outputs "hello world"


//string concatenation
string firstName2 = "John";
string lastName2 = "Doe";
string name3 = firstName2 + lastName2;
Console.WriteLine(name3);//output JohnDoe

string firstName3 = "John ";
string lastName3 = "Doe";
string name4 = string.Concat(firstName3, lastName3);
Console.WriteLine(name4);
Console.WriteLine(name3);//output John Doe

int ss = 10;
int tt  = 20;
int uu = ss + tt;
Console.WriteLine(uu);

string aa1 = "10";
string bb1 = "20";
string cc1 = aa1 + bb1;
Console.WriteLine(cc1);//output 1020

//string interpolation

string firstName4 = "John";
string lastName4 = "Doe";
string name5 = $"My full name is {firstName4} {lastName4}.";
Console.WriteLine(name5);//output My full name is John Doe.

//access strings
string myString = "Hello";
Console.WriteLine(myString[0]);
Console.WriteLine(myString.IndexOf("e"));//output 1

//special characters in strings
//double quotes ""
 string txt2 = "We are the so-called \"Vikings\" from the north.";
  Console.WriteLine(txt2);

//single quote ''
string txt3 = "It's alright.";
    Console.WriteLine(txt3);

//backslash \
string txt4 = "The character \\ is called backslash.";
    Console.WriteLine(txt4);

//new line(\n)
string txt5 = "Hello\nWorld!";
    Console.WriteLine(txt5);

//tab(\t)
string txt6 = "Hello\tWorld!";
    Console.WriteLine(txt6);

//backspace(\b)
string txt7 = "Hello\bWorld!";
Console.WriteLine(txt7);

//BOOCLEANS

bool isSunny = true;
bool isRaining = false;
Console.WriteLine(isSunny);//output True
Console.WriteLine(isRaining);//output False

//IF....ELSE STATEMENTS
if (isSunny)
{
    Console.WriteLine("It's a sunny day!");
}
else
{
    Console.WriteLine("It's not a sunny day.");
}

if(20 > 18)
    {
    Console.WriteLine("20 is greater than 18");
}
else
{
    Console.WriteLine("20 is not greater than 18");
}


//THE ELSE STATEMENT
int time = 20;
if (time<18)
{
    Console.WriteLine("good day");
}
else
{
    Console.WriteLine("good evening");
}

//ELSE IF STATEMENT

int time2 = 22;
if (time2<22)
{
    Console.WriteLine("Good Morning");
}
else if (time <20)
{
    Console.WriteLine("Good Day");
}
else
{
    Console.WriteLine("Good Evening");
}

//Shorthand IF...ELSE (Ternary Operator)
int time3 = 20;
if(time3<20)
{
    Console.WriteLine("good day");
}
else
{
    Console.WriteLine("good evening");
}

//SWITCH

int day = 4;
switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
}


//WHILE LOOP
int i2 = 0;
while (i2 < 5)
{
    Console.WriteLine(i2);
    i2++;
}

int i3 = 0;
do
    {
    Console.WriteLine(i3);
    i3++;
} while (i3 < 5);


//FOR LOOP
for (int i4 = 0; i4 < 5; i4++)
{
    Console.WriteLine(i4);
}


for (int i4 = 1; i4 <= 2; ++i4)
{
    Console.WriteLine("Outer: " + i4);  // Executes 2 times

    // Inner loop
    for (int j1 = 1; j1 <= 3; j1++)
    {
        Console.WriteLine(" Inner: " + j1); // Executes 6 times (2 * 3)
    }
}


//FOReach LOOP
string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
foreach (string i4 in cars)
{
    Console.WriteLine(i4);
    }


//bREAK AND CONTINUE STATEMENTS

//#BREAK STATEMENT
for (int i5 = 0; i < 10; i5++)
{
    if (i5 == 4)
    {
        break;
    }
    Console.WriteLine(i5);
}

//#CONTINUE STATEMENT
for (int i6 = 0; i6 < 10; i6++)
{
    if (i6 == 4)
    {
        continue;
    }
    Console.WriteLine(i6);
}


//BREAK AND CONTINUE IN WHILE LOOP
int i7 = 0;
while (i7 < 10)
{
    Console.WriteLine(i7);
    i7++;
    if (i7 == 4)
    {
        break;
    }
    }

//ARRAYS

//create an array
string[] cars2 = { "Volvo", "BMW", "Ford", "Mazda" };
//access array elements
Console.WriteLine(cars2[0]);//output Volvo

//create an array of integers
int[] myNumbers = { 10, 20, 30, 40 };
//access array elements
Console.WriteLine(myNumbers[2]);//output 30

//change an array element
cars2[0] = "Opel";
Console.WriteLine(cars2[0]);

//array length
Console.WriteLine(cars2);

//loop through an array
for (int i8 = 0; i8 < cars2.Length; i8++)
{
    Console.WriteLine(cars2[i8]);
}

//foreach loop
foreach (string i9 in cars2)
{
    Console.WriteLine(i9);
}

//SORT an ARRAY
Array.Sort(cars2);
foreach (string i10 in cars2)
{
    Console.WriteLine(i10);
}

int[] myNumbers2 = { 5, 3, 8, 1, 2 };
Array.Sort(myNumbers2);         
foreach (int i11 in myNumbers2)
{
    Console.WriteLine(i11);
}

//MULTI-DIMENSIONAL ARRAYS
int[,] myNumbers3 = { { 1, 4, 2 }, { 3, 6, 8 } };
Console.WriteLine(myNumbers3[0,2]);

//changingb elements of 2d array
myNumbers3[0, 0]  = 5;
Console.WriteLine(myNumbers3[0, 0]);

//loop through 2d array
foreach (int i12 in myNumbers3)
{
       Console.WriteLine(i12);

}



//create a simple winfrom application with example it is called desktop level work
//how to deploy code in .net application
//how works exceptions handling
//class to class method communication
//communication between class and object
//reusability 
//inbuilt packages in .net
//how to work DDL in .net
//c# + ADO .net connect activity