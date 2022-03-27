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

        class Human : Ihuman
        {
            public int Id { get; set; }
            public int Age { get; set; }
            public bool IsMarried { get; set; }

            //public Human(int id, int age,bool isMarried) 
            //{
            //    this.Id = id; this.Age = age; this.IsMarried = isMarried;
            //}

        }
        class AboutHuman : Human
        {
            public string Name { get; set; }
            //public AboutHuman(int id, string name,int age, bool isMarried) : base(id,age,isMarried)
            //{
            //    this.Name = name;
            //}
        }
        class SalaryHuman : AboutHuman
        {
            public decimal Salary { get; set; }
            //public SalaryHuman(int id, decimal salary, int age,string name,bool isMarried) : base(id, name,age, isMarried)
            //{
            //    this.Salary = salary;
            //}

        }
        interface Ihuman
        {
            bool IsMarried { get; set; }
        }
        class FamilyMember : SalaryHuman, Ihuman
        {
            public string FamilyMembers { get; set; }
            //public FamilyMember(int id, decimal salary, int age, string name,
            //    string familyMembers,bool isMarried) :base(id, salary,age, name, isMarried)
            //{
            //    this.FamilyMembers = familyMembers;
            //}


            public void GetfamilyMembers(bool isMarried)
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
            //    Human a = new Human(1, 20, true);
            //    Human aa = new Human(2, 25, false);
            //    AboutHuman b = new AboutHuman(1, "Aram", 20, true);
            //    AboutHuman bb = new AboutHuman(2, "Ani", 25, false);
            //    SalaryHuman c = new SalaryHuman(1, 300000, 20, "Aram", true);
            //    SalaryHuman cc = new SalaryHuman(2, 2500000, 25, "Ani",false);
            //    FamilyMember d = new FamilyMember(1, 300000, 20, "Aram", "Ani Anyan, Poghos Poghosyan", true);
            //    FamilyMember dd = new FamilyMember(2, 2500000, 25, "Ani", " null", false);

            List<Human> list = new List<Human>();
            list.Add(new Human { Id = 1, Age = 20, IsMarried = true });
            list.Add(new Human { Id = 2, Age = 25, IsMarried = false });
            List<AboutHuman> list1 = new List<AboutHuman>();
            list1.Add(new AboutHuman { Id = 1, Age = 20, IsMarried = true, Name = "Aram" });
            list1.Add(new AboutHuman { Id = 2, Age = 25, IsMarried = false, Name = "Ani" });
            List<SalaryHuman> list2 = new List<SalaryHuman>();
            list2.Add(new SalaryHuman { Id = 1, Name = "Aram", Age = 20, IsMarried = true });
            list2.Add(new SalaryHuman { Id = 2, Name = "Ani", Age = 25, IsMarried = false });
            List<FamilyMember> list3 = new List<FamilyMember>();
            list3.Add(new FamilyMember { Id = 1, Name = "Aram", Age = 20, IsMarried = true, Salary = 3000000, FamilyMembers = "ANi Anyan, Poghos Poghosyan" });
            List<FamilyMember> list4 = new List<FamilyMember>();
            list4.Add(new FamilyMember { Id = 2, Name = "Ani", Age = 25, IsMarried = false, Salary = 250000, FamilyMembers = "null" });
            Human a = new Human();
            Console.WriteLine("Please entre Id...");
            a.Id = int.Parse(Console.ReadLine());
            switch (a.Id)
            {
                case 1:
                    foreach (var item in list3)
                    {
                        Console.WriteLine("id is " + item.Id + ", age is " + item.Age + ", Name is " + item.Name + ", salary is " + item.Salary + ", family mambers are " + item.FamilyMembers);
                    }
                    break;

                case 2:
                    foreach (var item in list4)
                    {
                        Console.WriteLine("id is " + item.Id + ", age is " + item.Age + ", Name is " + item.Name + ", salary is " + item.Salary + ", family mambers are " + item.FamilyMembers);
                    }

                    break;
                default:
                    Console.WriteLine("id doesn't find");
                    break;
            }
        }
    }
}
