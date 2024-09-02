/******************************************************************************
* Filename    = IVisitor.cs
*
* Author      = Hitesh Yasam
*
* Product     = SoftwareDesignPatterns
* 
* Project     = VisitorPatternDemo
*
* Description = The Visitor Interface declares the Visit Method that corresponds to the Element class. 
                The Visit Method will accept the IElement object as a parameter i.e. the concrete class 
                which implements the IElement Interface. In this case the Kid object
*****************************************************************************/
namespace VisitorDesignPattern
{
    public interface IVisitor
    {
        void Visit(IElement element);
    }
}