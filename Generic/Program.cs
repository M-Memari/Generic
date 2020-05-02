using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> listInt = new GenericList<int>();
            listInt.AddItem(1);
            GenericList<string> listString = new GenericList<string>();
            listString.AddItem("");
            GenericList<ExampleClass> listExamplClass = new GenericList<ExampleClass>();
            listExamplClass.AddItem(new ExampleClass());
        }
    }
}
