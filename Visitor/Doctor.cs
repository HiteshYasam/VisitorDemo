/******************************************************************************
* Filename    = Doctor.cs
*
* Author      = Hitesh Yasam
*
* Product     = SoftwareDesignPatterns
* 
* Project     = VisitorPatternDemo
*
* Description =  Concrete Visitors implement several versions of the same algorithm, 
                 which can work with all concrete component classes. The following 
                 Concrete Visitor class implements the Visit Method declared by Visitor Interface.
                 The Visit Method implements a fragment of the algorithm defined for the corresponding Element class.
*****************************************************************************/

using System;
namespace VisitorDesignPattern
{ 
    public class Doctor : IVisitor
    {
        public string Name { get; set; }

        public Doctor(string name)
        {
            Name = name;
        }

        //The Following is the Method we want to execute for each element of the collection or Data Structure
        public void Visit(IElement element)
        {
            Kid kid = (Kid)element;
            Console.WriteLine($"Doctor: {Name} did the health checkup of the child: {kid.KidName}");
        }
    }
}