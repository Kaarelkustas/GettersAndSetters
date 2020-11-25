using System;

namespace GettersAndSetters
{
    class Program
    {
        class Person
        {
             string name;
             int age;
             string gender;
             string idCode;

            public Person(string  _name, string  _gender, int _age, string _idCode)
            {
                Name = _name;
                Gender = _gender;
                age = _age;
                IdCode = _idCode;
            }
            public string Name
            {
                get { return name;  }
                set
                {
                    name = value;
                }
            }
            public string Gender
            {
                get { return gender; }
                set
                {
                    if (value == "male" || value == "female")
                    {
                        gender = value;
                    }else
                    {
                        gender = "vale vastus lammas";
                    }
                }
            }
            public string IdCode
            {
                get { return idCode; }
                set
                {
                    if(value.Length == 11)
                    {
                        idCode = value;
                    }else
                    {
                        idCode = "underfined";
                    }
                }
            }
        }
       
        static void Main(string[] args)
        {
            Person newPerson = new Person("Harry Potter", "gmail" , 35 , "1234");
            Console.WriteLine(newPerson.Name);
            //Console.WriteLine(newPerson.Age);
            Console.WriteLine(newPerson.Gender);
            //newPerson.name = "Harry Potter";
            //newPerson.gender = "female";
            //newPerson.age = 21;
            Console.WriteLine(newPerson.Name);
            //Console.WriteLine(newPerson.age);
            //Console.WriteLine(newPerson.gender);
            newPerson.Name = "Harry Pothead";
        }
    }
}
