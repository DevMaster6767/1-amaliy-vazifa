using System.Net.NetworkInformation;
//1. Doira yuzi va aylana uzunligini hisoblash
Console.Write("radiusni keriting=> ");
double radius = Convert.ToDouble(Console.ReadLine());
const double Pi= 3.1415926535897932384626433832795; 
double S = Pi*Math.Pow(radius,2);
double L = 2*Pi*radius;
Console.WriteLine($"Doiraning yuzi: {S}, aylananing uzunligi: {L}");

//2. Valyuta konvertri
Console.Write("summa qiymatini keriting=> ");
double qiymat = Convert.ToDouble(Console.ReadLine());
Console.Write("valyuta kursini keriting=> ");
double kurs = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Konvertatsiya qilingan summa: {qiymat*kurs} so'm");

//3. Yoshni hisoblash
Console.Write("Tug'ilgan yilingizni keriting=> ");
int TYil =Convert.ToInt32(Console.ReadLine());
Console.Write("hozirgi yilni keriting=> ");
int yil =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"yoshingizni kunlarda ifodalanishi: {365*(yil-TYil)} kun");