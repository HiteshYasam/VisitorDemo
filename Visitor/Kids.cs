/******************************************************************************
* Filename    = Kids.cs
*
* Author      = Hitesh Yasam
*
* Product     = SoftwareDesignPatterns
* 
* Project     = VisitorPatternDemo
*
* Description = The Concrete Element implements the Accept operation that takes a visitor as an argument
*****************************************************************************/
namespace VisitorDesignPattern
{
    public class Kid : IElement
    {
        public string KidName { get; set; }
        public Kid(string name)
        {
            KidName = name;
        }

        //The following Method will call the Concrete Visitor Visit method by passing the current Kid Object
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}