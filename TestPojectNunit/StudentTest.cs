using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitLibrary;

namespace TestPojectNunit
{
    public class StudentTest
    {
        [Test]
        public void TestStudentName()
        {
            // Arrange
            Student student = new Student();
            student.Name = "Narendra";
            // Act
            string studentName = student.Name;
            // Assert
            Assert.AreEqual("Narendra", studentName);
        }
        [Test]
        public void TestStudentAddress()
        {
            // Arrange
            Student student = new Student();
            student.Address = "2-42 Hyd";
            // Act
            string studentAddress = student.Address;
            // Assert
            Assert.AreEqual("2-42 Hyd", studentAddress);
        }
    }
}
