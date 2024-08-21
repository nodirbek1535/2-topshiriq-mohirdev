// using System;
// Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa
// 1. Kalkulyator:
// Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.
// Input = 5;
// Input = +;
// Input = 5;
// Output = 10;
Console.WriteLine("1-Ropshiriq kalkulator");
double a,b;
char k;
Console.WriteLine("1-sonni kiriting");
a=double.Parse(Console.ReadLine());
Console.WriteLine("amalni tanlang {+,-,/,*}");
k=char.Parse(Console.ReadLine());
Console.WriteLine("2-sonni kiriting");
b=double.Parse(Console.ReadLine());
if(k=='+')
{
    Console.WriteLine("a+b="+(a+b));
}
else if(k=='-')
{
    Console.WriteLine("a-b="+(a-b));
}
else if(k=='*')
{
    Console.WriteLine("a*b="+(a*b));
}
else{
     Console.WriteLine("a/b="+(a/b));
   
}
Console.WriteLine("1-topshiriq yakunlandi ");
Console.WriteLine("---------------------------------------------------------------------------");
// 2. Raqamlar qatorining yig‘indisini hisoblash:
// Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab, natijani ekranga chiqaradigan dastur tuzing.
// Input = 10;
// Output = 55;
Console.WriteLine("2-topshiriq raqamlar yigindisi");
uint num;
Console.WriteLine("num=");
num=uint.Parse(Console.ReadLine());
int sum=0;
for(int i=0;i<=num;i++)
{
   sum+=i;
}
Console.WriteLine("sunmma="+sum);
Console.WriteLine("2-topshiriq yakunlandi ");
Console.WriteLine("---------------------------------------------------------------------------");
// 3.  Paritet tekshiruvi:
// Foydalanuvchi kiritgan raqamning juft yoki toq ekanligini aniqlaydigan va shunga mos ravishda xabarni chiqaradigan dastur tuzing.
// Input = 3;
// Output = “Toq”
Console.WriteLine("3-topshiriq paritet");
int init;
Console.WriteLine("tekishirmoqchi bolgan soningizni kiriting:");
init=int.Parse(Console.ReadLine());
if(init%2==0)
{
    Console.WriteLine("juft");
}
else{
    Console.WriteLine("toq");
}
Console.WriteLine("3-topshiriq yakunlandi ");
Console.WriteLine("---------------------------------------------------------------------------");