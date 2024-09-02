/******************************************************************************
* Filename    = VistorTest.cs
*
* Author      = Hitesh Yasam
*
* Product     = SoftwareDesignPatterns
* 
* Project     = VisitorTests
*
* Description = This file contains the implementation of the Visitor design pattern.
*               It defines a `School` class that represents an object structure 
*               containing a collection of `Kid` elements. The `School` class allows 
*               visitors to perform operations on each `Kid` element by invoking the 
*               `Accept` method of the `Kid` class. This file also includes the setup 
*               for the Visitor pattern, including the `Doctor` and `Salesman` visitor 
*               implementations, which demonstrate different operations on the `Kid` 
*               elements. The `School` class provides a method to apply any visitor 
*               to all contained elements, showcasing the separation of concerns and 
*               extensibility benefits of the Visitor pattern. 
*****************************************************************************/

using NUnit.Framework;
using System;
using System.IO;
using System.Text;

namespace VisitorDesignPattern.Tests
{
    [TestFixture]
    public class VisitorTests
    {
        private School _school;
        private StringWriter _output;

        [SetUp]
        public void Setup()
        {
            // Initialize the School instance and capture Console output
            _school = new School();
            _output = new StringWriter();
            Console.SetOut(_output);
        }

        [TearDown]
        public void TearDown()
        {
            // Dispose of StringWriter and reset Console output
            _output.Dispose();
            Console.SetOut(Console.Out);
        }

        [Test]
        public void DoctorVisitsSchool1()
        {
            // Arrange
            var visitor = new Doctor("HiteshYasam");

            // Act
            _school.PerformOperation(visitor);

            // Assert
            var expectedOutput = new StringBuilder()
                .AppendLine("Doctor: HiteshYasam did the health checkup of the child: Ram")
                .AppendLine("Doctor: HiteshYasam did the health checkup of the child: Sara")
                .AppendLine("Doctor: HiteshYasam did the health checkup of the child: Pam")
                .ToString();

            Assert.AreEqual(expectedOutput, _output.ToString());
        }

        [Test]
        public void DoctorVisitsSchool2()
        {
            var visitor = new Doctor("JamesCameron");

            _school.PerformOperation(visitor);

            var expectedOutput = new StringBuilder()
                .AppendLine("Doctor: JamesCameron did the health checkup of the child: Ram")
                .AppendLine("Doctor: JamesCameron did the health checkup of the child: Sara")
                .AppendLine("Doctor: JamesCameron did the health checkup of the child: Pam")
                .ToString();

            Assert.AreEqual(expectedOutput, _output.ToString());
        }

        [Test]
        public void SalesmanVisitsSchool1()
        {

            var visitor = new Salesman("JohnSimen");

            _school.PerformOperation(visitor);

            var expectedOutput = new StringBuilder()
                .AppendLine("Salesman: JohnSimen give a school bag to the child: Ram")
                .AppendLine("Salesman: JohnSimen give a school bag to the child: Sara")
                .AppendLine("Salesman: JohnSimen give a school bag to the child: Pam")
                .ToString();

            Assert.AreEqual(expectedOutput, _output.ToString());
        }
        [Test]
        public void SalesmanVisitsSchool2()
        {
            var visitor = new Salesman("Karthik");

            _school.PerformOperation(visitor);

            var expectedOutput = new StringBuilder()
                .AppendLine("Salesman: Karthik give a school bag to the child: Ram")
                .AppendLine("Salesman: Karthik give a school bag to the child: Sara")
                .AppendLine("Salesman: Karthik give a school bag to the child: Pam")
                .ToString();

            Assert.AreEqual(expectedOutput, _output.ToString());
        }

    }
}
