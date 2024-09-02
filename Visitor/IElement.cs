/******************************************************************************
* Filename    = IElement.cs
*
* Author      = Hitesh Yasam
*
* Product     = SoftwareDesignPatterns
* 
* Project     = VisitorPatternDemo
*
* Description =  The Element interface declares an Accept method that should take the
                 base visitor interface as an argument.
*****************************************************************************/
namespace VisitorDesignPattern
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}