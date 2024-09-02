/******************************************************************************
* Filename    = Salesman.cs
*
* Author      = Hitesh Yasam
*
* Product     = SoftwareDesignPatterns
* 
* Project     = VisitorPatternDemo
*
* Description = The following Concrete Visitor class implements the Visit Method declared by Visitor Interface. 
                The Visit Method implements a fragment of the algorithm defined for the corresponding Element class. 
*****************************************************************************/
using System;
namespace VisitorDesignPattern
{
    
    public class Salesman : IVisitor
    {
        public string Name { get; set; }

        public Salesman(string name)
        {
            Name = name;
        }

        //The Following is the Method we want to execute for each element of the collection or Data Structure
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Salesman: {Name} give a school bag to the child: {kid.KidName}");
        }
    }
}