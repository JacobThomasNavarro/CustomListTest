using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomList.UnitTest
{
    [TestClass]
    public class CustomListUnitTest
    {
        // unit test for adding multiple items to check position of last item
        // unit test for adding multiple items to check Count property
        // unit test for adding number of items beyond 'Capacity' but it still adds

        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 12;
            int actual;

            // act
            testList.Add(12);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            // act
            testList.Add(234);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemsToList_BeyondCapacityCount()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 5;
            int actual;

            testList.Add(6);
            testList.Add(5);
            testList.Add(4);
            testList.Add(3);
            testList.Add(2);
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_AddItemsToList_BeyondCapacityLastIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            testList.Add(6);
            testList.Add(5);
            testList.Add(4);
            testList.Add(3);
            testList.Add(2);
            actual = testList[4];

            Assert.AreEqual(expected, actual);
        }
        public void Add_AddItemsToList_CheckLastIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 3;
            int actual;

            testList.Add(5);
            testList.Add(4);
            testList.Add(3);
            actual = testList[2];

            Assert.AreEqual(expected, actual);
        }
    }
}
