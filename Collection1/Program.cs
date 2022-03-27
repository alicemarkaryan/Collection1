using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collection1
{
    internal class Program
    {

        class A:Ihuman
        {
            public int Id { get; set; }
            public int Age { get; set; }
            public bool IsMarried { get; set; }

            //public A(int id, int age,bool isMarried) 
            //{
            //    this.Id = id; this.Age = age; this.IsMarried = isMarried;
            //}






        }
        class B:A
        {
            public string Name { get; set; }
            //public B(int id, string name,int age, bool isMarried) : base(id,age,isMarried)
            //{
            //    this.Name = name;
            //}
        }
        class C : B
        {
            public decimal Salary { get; set; }
            //public C(int id, decimal salary, int age,string name,bool isMarried) : base(id, name,age, isMarried)
            //{
            //    this.Salary = salary;
            //}

        }
        interface Ihuman
        {
             bool IsMarried {get;set;}
        }
        class D:C,Ihuman
        {
            public string FamilyMembers { get; set; }
            //public D(int id, decimal salary, int age, string name,
            //    string familyMembers,bool isMarried) :base(id, salary,age, name, isMarried)
            //{
            //    this.FamilyMembers = familyMembers;
            //}
            
            
            public void getfamilyMembers(bool isMarried)
            {
                if (isMarried)
                {
                    Console.WriteLine(FamilyMembers);
                }
                else
                {
                    Console.WriteLine("null");
                }

            }
        }

        static void Main(string[] args)
        {
        //    A a = new A(1, 20, true);
        //    A aa = new A(2, 25, false);
        //    B b = new B(1, "Aram", 20, true);
        //    B bb = new B(2, "Ani", 25, false);
        //    C c = new C(1, 300000, 20, "Aram", true);
        //    C cc = new C(2, 2500000, 25, "Ani",false);
        //    D d = new D(1, 300000, 20, "Aram", "Ani Anyan, Poghos Poghosyan", true);
        //    D dd = new D(2, 2500000, 25, "Ani", " null", false);

            List<A> list = new List<A>();
            list.Add(new A { Id = 1, Age = 20, IsMarried=true });
            list.Add(new A { Id = 2, Age = 25, IsMarried = false });
            List<B> list1 = new List<B>();
            list1.Add(new B { Id = 1, Age = 20, IsMarried = true, Name = "Aram" });
            list1.Add(new B { Id = 2, Age = 25, IsMarried = false, Name = "Ani" });
            List<C> list2 = new List<C>();
            list2.Add(new C { Id = 1, Name = "Aram", Age = 20, IsMarried = true });
            list2.Add(new C { Id = 2, Name = "Ani", Age = 25, IsMarried = false });
            List<D> list3 = new List<D>();
            list3.Add(new D { Id = 1, Name = "Aram", Age = 20, IsMarried = true,Salary=3000000, FamilyMembers="ANi Anyan, Poghos Poghosyan" });
            List<D> list4 = new List<D>();
            list4.Add(new D { Id = 2, Name = "Ani", Age = 25, IsMarried = false, Salary = 250000, FamilyMembers = "null" });
            A a = new A();
            Console.WriteLine("Please entre Id...");
            a.Id = int.Parse(Console.ReadLine());
            if (a.Id == 1)
            {
                foreach (var item in list3)
                {
                    Console.WriteLine("id is "+item.Id+", age is "+item.Age+", Name is "+item.Name+", salary is "+item.Salary+", family mambers are "+item.FamilyMembers);
                }
                
            }
            else if(a.Id == 2)
            {
                foreach (var item in list4)
                {
                    Console.WriteLine("id is " + item.Id + ", age is " + item.Age + ", Name is " + item.Name + ", salary is " + item.Salary + ", family mambers are " + item.FamilyMembers);
                }

            }
            else
            {
                Console.WriteLine("id doesn't find");
            }







        }
    }
}
