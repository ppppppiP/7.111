//7.111.Известны стоимости(в долларах) нескольких марок легковых автомобилей и мотоциклов.
//Верно ли, что средняя стоимость автомобилей превышает сред-нюю стоимость мотоциклов более чем в 3 раза?
//Стоимость одного автомо-биля превышает $5000, что больше стоимости любой марки мотоцикла.
int[] kar = new int[255];
int[] moto = new int[255];
double  b = 0;
double a = 0;
int n, i;


Console.WriteLine("Введите количество Машин и Мотоциклов: ");
n = Convert.ToInt32(Console.ReadLine());
for ( i= 1; i<=n; i++) { 
    Console.WriteLine("Введите стоимость "+ i + "й"+ " машины: ");
kar[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 1; i <= n; i++)
{
    Console.WriteLine("Введите стоимость " + i + "" + " мотоцикла: ");
    moto[i] = Convert.ToInt32(Console.ReadLine());
}
for (i = 1;  i<n; i++) { 
a = a + kar[i];
b = b + moto[i];
}
a = a / n;
b = b / n;
if ((a / 3) > b) {
    Console.WriteLine("Верно!"); 
}
else {
    Console.WriteLine("Не верно!");

}