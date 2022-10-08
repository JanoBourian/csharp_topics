using System;

namespace AObjects
{
    class Members
    {
        // members can be private fields
        private string first_name;
        private string last_name;
        private float amount;

        // member can be public fields
        public int age;

        // members as properties
        public int MyProperty { get; set; }

        // members as private methods
        private void SharePrivateInfo(){}

        // members as public methods
        public void SharePublicInfo() {}

        // constructor
        public Members(){}

        // members finisher/destroyer
        ~Members()
        {
            Console.WriteLine("I had destroyed the class");
            Console.ReadLine();
        }


    }
}
