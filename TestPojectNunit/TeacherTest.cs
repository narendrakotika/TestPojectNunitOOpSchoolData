using NunitLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPojectNunit
{
    [TestFixture]
    public class TeacherTest
    {
        [Test]
        public void TestTeacherName()
        {
            // Arrange
            Teacher myTeacher = new Teacher();
            myTeacher.Name = "Suresh";
            // Act
            string teacherName = myTeacher.Name;
            // Assert
            Assert.AreEqual("Suresh", teacherName);
        }
        [Test]
        public void TestClassId()
        {
            // Arrange
            Teacher myTeacher = new Teacher();
            myTeacher.Id = 1;
            // Act
            int tecaherId = myTeacher.Id;
            // Assert
            Assert.AreEqual(1, tecaherId);
        }
    }
}
