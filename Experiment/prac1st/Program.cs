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