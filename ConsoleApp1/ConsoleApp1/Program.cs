//-Static useriniz olacaq username : "admin"; password: "admin"
//- User login olduqda kredit menusu acilacaq
//- 3 secim olacaq : Kredit goturmek, Kredit odemek , hesabat
//- Sizdə məbləğ , ay, faiz, ümumi ödəniləcək məbləğ və aylıq ödəniş deyə variable olacaq.
//User Ay daxil edəcək . Daha sonra console userə faiz dərəcəsini göstərəcək
//İlk öncə proqram aylar üçün faizi hesablamalıdır , əgər userin daxil etdiyi müddət bir
//ildən azdırsa 12% bir ildən çoxdursa 18% ilə hesablanacaq.
//Daha sonra user məbləğ daxil edəcək.  
//Daha sonra console-da ümumi ödəniləcək məbləğ və aylıq ödəniş ekranda görünəcək.
//Bunun flowchartları da yazılmalıdır.
/////////////////////////////////////////////////////////////////////////////////////////////////////////



string UserName = "feridnasirli";
string UserPassword = "ferid2003";
int price=0;    
int month=0;
int secim = 0;
int a_prise =0;
int a_pay = 0;
string agree;
int reprice = 0;
int remonth = 0;
int payment = 0;
int paynum = 0;
int mopay = 0;
Console.WriteLine("useri gir:");
UserName = Console.ReadLine();
Console.WriteLine("password gir:");
UserPassword = Console.ReadLine();
if (UserName == "feridnasirli" && UserPassword == "ferid2003")
 {
    Console.WriteLine("                                  Kredit Menusuna Xosh Geldiz!!!");
    Console.WriteLine("-----------------------------------------------------------------------------------------------------------------");
    secim1:
    Console.WriteLine("\n \n 1.Kredit goturmek \n 2.Kredit odemek \n 3.hesabat");
    Console.WriteLine("emeliyyati sec:");
    secim = Convert.ToInt32(Console.ReadLine());
    if (secim==1)
    {       

        Console.WriteLine("Ay daxil ed:");   
        month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Mebleg: ");
        price = Convert.ToInt32(Console.ReadLine());
        a_prise = price + price * 12 / 100;
        if (month <= 12)
        {
            Console.WriteLine("Verilecek mebleg: " + a_prise);
        }
        else
        {
            Console.WriteLine("Verilecek mebleg: " + a_prise);
        }
         


    }
}
else
 {
    Console.WriteLine("Sehv username ve ya userpassword" +
        "Yeniden cehd edin:");
}
Console.WriteLine("Razisiz? \n He \n Yox?" );
agree = Console.ReadLine();
if (agree == "1")
{
    Console.WriteLine("Ugurludur!");
    reprice = a_prise;
    remonth = month;
    goto secim1 ;
}

else if (secim == 2)
{
    Console.WriteLine("Ayliq odenish: " + mopay);
paymentt:
    Console.WriteLine("odemek ucun 1 vur");
    payment = Convert.ToInt32(Console.ReadLine());
    if (paynum == 1)
    {
        Console.WriteLine("odenish ugurlu oldu");
        reprice = reprice - mopay;
        remonth = remonth - 1;
        Console.WriteLine("qalan borc" + reprice);
        Console.WriteLine("qalan ay" + remonth);

    }
    else
{ 
    Console.WriteLine("odenish olmadi!"); 
}
}



 else if (secim==3)
{
    Console.WriteLine(reprice);
    Console.WriteLine(remonth);
}