using System;
using System.Collections;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {
            string message="Hello";
            Console.WriteLine(message);
            Property p = new Property();
            p.StudentId = 6;
            Console.WriteLine(p.StudentId);

            StudentObject student= new StudentObject();
            student.FirstName = "Baver";
            student.LastName = "Talantimur";
            student.GetFullName();
            //DateTime
            DateTime dt1=new DateTime();
            DateTime dt2 = new DateTime(2020, 12, 31); 
            DateTime dt3=new DateTime(2020,12,31,10,12,15);
            Console.WriteLine(dt1);
            Console.WriteLine(dt2.ToString());
            Console.WriteLine(dt1.ToString());
            Console.WriteLine(dt3);
            
            Console.WriteLine("--------");
            DateTime dt4 = new DateTime(2000,07,26,07,15,20);
            int year = dt4.Year;
            int month = dt4.Month;
            int day = dt4.Day;
            int hour = dt4.Hour;
            int minute = dt4.Minute;
            int second = dt4.Second;
            int weekday = (int)dt4.DayOfWeek;
            Console.WriteLine("Yıl: "+ year + " AY: "+month+" Gun: "+day+ " saat: "+hour+" minute: "+minute+" second: "+second+" weekday: "+weekday);

            DateTime dt5 = DateTime.Now;
            Console.WriteLine(dt5.ToString("MM/dd/yyyy"));
            Console.WriteLine(dt5.ToString("HH:mm")); // saat dakika
            Console.WriteLine(dt5.ToString("hh:mm tt")); // öğleden sonra
            Console.WriteLine(dt5.ToString("dddd, dd MMMM yyyy HH:mm:ss"));// gün,tarih saat
            Console.WriteLine(dt5.ToString("MM/dd/yyyy HH:mm:ss"));
            DateTime dt = new DateTime(2020, 11, 14);
            Console.WriteLine("Haftanın günü {0:d} is {1}.", dt, dt.DayOfWeek);
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
            DayOfWeek.Monday,
            DayOfWeek.Tuesday,
            DayOfWeek.Wednesday,
            DayOfWeek.Thursday,
            DayOfWeek.Friday,
            DayOfWeek.Saturday,
            DayOfWeek.Sunday);
            Console.WriteLine("-----");
            DayOfWeek dayOfWeek = DateTime.Today.DayOfWeek;
            Console.WriteLine(dayOfWeek);
            //ArrayList
            ArrayList arlist = new ArrayList();
            arlist.Add(1);
            arlist.Add("baver");
            arlist.Add("talantimur");
            arlist.Add(4.5);
            arlist.Add(null);
            Queue myq=new Queue();
            myq.Enqueue("Helloworld");
            int[] arrays = { 100, 200, 300 };
            

            ArrayList arlist2=new ArrayList();
            arlist2.AddRange(arlist); //  collection ekleme
            arlist2.AddRange(arrays);
            arlist2.AddRange(myq);
            foreach(var item in arlist2)
                Console.WriteLine(item);
            /*for(int i = 0; i < arlist2.Count; i++)
                Console.WriteLine(arlist2[i]);*/
            Console.WriteLine("-----");

            ArrayList arlist3 = new ArrayList()
            {
                1,"BAWER",300,4.5F
            };
            arlist3.Insert(1, "Second İtem"); //1.indexe second item ekle ;
            foreach(var item in arlist3)
                Console.WriteLine(item);

            Console.WriteLine("-----");
            ArrayList arlist4 = new ArrayList() { 
                500,600,700
            };
            arlist4.InsertRange(2,arlist3); // 2. indexe arrlist3 ekle
            foreach(var item in arlist4)
                Console.WriteLine(item);

            //remove islemleri


            arlist4.RemoveRange(0, 2); // o ile ikinci index  dahil arasını kaldırır
            arlist4.Remove(3);
            arlist4.RemoveAt(1);// 1.index kaldırır
            Console.WriteLine("-----");
            foreach (var item in arlist4)
                Console.WriteLine(item);

            Console.WriteLine(arlist4.Contains(700));







        }

    }
}

