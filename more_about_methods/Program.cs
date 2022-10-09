using System;

namespace more_about_methods
{
    class program
    {



        static void Main(string[] args)
        {

            student Std = new student();
            Std.fullName("asa", "dsf");
            Console.WriteLine(Std.getFullName);
            teacher tc = new teacher("asap", "dasty");
            Console.WriteLine(tc.getFullName);

        }
    }


    class student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void fullName(string fn, string ln)
        {
            this.firstName = fn;
            this.lastName = ln;

            Console.WriteLine(fn + ln);
        }

        public virtual String getFullName
        {
            get
            {
                return "Student Full name:  {0}:" + this.firstName + " " + this.lastName;
            }
        }
    }

    class teacher : student
    {
        public teacher(string fn, string ln)
        {

            this.firstName = fn;
            this.lastName = ln;
        }
        public override String getFullName
        {
            get
            {
                return "Teacher Full name:  {0}:" + this.firstName + " " + this.lastName;

            }

        }


    }
}
