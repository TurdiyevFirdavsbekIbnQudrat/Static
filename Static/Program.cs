// See https://aka.ms/new-console-template for more information
using Libraryyyy;
using System.Net;

Person Yigit=new Person();
Person Qiz=new Person();
Yigit.Ism = "Umid";
Qiz.Ism = "Gulshanoy";

Yigit.Oilalimi = false;
Qiz.Oilalimi = false;

Person.OilaMumkinmi(Yigit, Qiz);
Yigit.OilasiBor(Qiz);