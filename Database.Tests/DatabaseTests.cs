using NUnit.Framework;
using System;


namespace Database
{
    public class DatabaseTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        
        
        public void TestsThatTheStoringArrayCappacityIsEqualTo16()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

            var expectedResult = 16;
            var actualResult = database.Count;

            Assert.AreEqual(expectedResult,actualResult);
        }
       
        [Test]
        public void ThrowExceptionIfTheAddMethodAddOver16Elements()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            var extraElement = 17;
            database.Add(16);

            Assert.Throws<InvalidOperationException>(() => database.Add(extraElement));
        }
        [Test]
        public void TestsIfTheAddMethodCanAddElements()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

            
            database.Add(16);
            var expectedResult = 16;
            var actualResult = database.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void TestsIfTheRemoveMethodCanRemoveLastElement()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);


            database.Remove();
            var expectedResult = 14;
            var actualResult = database.Fetch()[13];

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void ThrowExceptionIfTheRemoveMethodTryToRemoveFromEmptyDataBase()
        {
            Database database = new Database();           

            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void TestsIfTheFetchMethodReturnsArray()
        {
            Database database = new Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);


           
            var expectedResult = database.Count;
            var Result = database.Fetch().Length;

            Assert.AreEqual(expectedResult, Result);
        }
    }
}